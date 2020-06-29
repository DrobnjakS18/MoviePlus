using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MoviePlus.API.Core;
using MoviePlus.Application;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Email;
using MoviePlus.Application.Queries;
using MoviePlus.DataAccess;
using MoviePlus.Implementation.Commands;
using MoviePlus.Implementation.Email;
using MoviePlus.Implementation.Logging;
using MoviePlus.Implementation.Queries;
using MoviePlus.Implementation.Validation;
using Newtonsoft.Json;

namespace MoviePlus.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var settings = new ApiSettings();

            Configuration.Bind(settings);

            services.AddControllers();

            services.AddTransient<MoviePlusContext>();
            services.AddTransient<IUseCaseLogger, DatabaseUseCaseLogger>();
            services.AddTransient<IGetMovieQuery, GetMovieQuery>();
            services.AddTransient<IGetUsersQuery, GetUsersQuery>();
            services.AddTransient<IGetLogQuery, GetLogQuery>();
            services.AddTransient<IGetUserQuery, GetUserQuery>();

            services.AddTransient<IMovieInsert, MovieInsert>();
            services.AddTransient<IDeleteMovie, DeleteMovie>();

            services.AddTransient<IRegisterUser, RegisterUser>();
            services.AddTransient<RegisterUserValidator>();
            services.AddTransient<InsertMovieValidator>();
            services.AddTransient<InsertScreeningValidator>();
            services.AddHttpContextAccessor();
            services.AddTransient<IApplicationUser>(x =>
            {
                var accessor = x.GetService<IHttpContextAccessor>();
                //izvuci token
                //pozicionirati se na payload
                //izvuci ActorData claim
                //Deserijalizovati actorData string u c# objekat

                var user = accessor.HttpContext.User;

                if (user.FindFirst("ActorData") == null)
                {
                    return new AnonymusActor();
                }

                //Pristupamo ActorData i vracamo objekat koji predstavlja sve podatke o korinsiku koji salje request
                var actorString = user.FindFirst("ActorData").Value;

                var actor = JsonConvert.DeserializeObject<JwtActor>(actorString);

                return actor;

            });
            services.AddTransient<UseCaseExecutor>();
            services.AddTransient<IUseCaseLogger, DatabaseUseCaseLogger>();
            services.AddTransient<IEmailSender, SenderEmail>(x => new SenderEmail(settings.SenderEmail, settings.SenderEmailPassword));

            services.AddTransient<JwtManager>(x =>
            {
                var context = x.GetService<MoviePlusContext>();

                //Upis Issuera i secretKey dinamicki iz konfiguracionog fajla
                return new JwtManager(context, settings.JwtIssuer, settings.JwtSecretKey);
            });
            services.AddTransient<UseCaseExecutor>();


            //Validacija tokena
            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = settings.JwtIssuer,
                    ValidateIssuer = true,
                    ValidAudience = "Any",
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.JwtSecretKey)),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //Handlovanje globaling gresaka preko middlewara
            app.UseMiddleware<GlobalExceptionHandler>();

            //Dozvoljavamo slanje zahteva sa bilo kog domena, na taj nacin komuniciramo sa frontend
            app.UseCors(x =>
            {
                x.AllowAnyOrigin();
                x.AllowAnyMethod();
                x.AllowAnyHeader();
            });

            //Validacija tokena
            app.UseAuthentication();
            app.UseAuthorization();

            //Omogucavamo prikaz slika kada pristupimo na webu 
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MoviePlus.DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlus.API.Core
{
    public class JwtManager
    {
        private readonly MoviePlusContext _context;
        private readonly string _issuer;
        private readonly string _secretKey;

        public JwtManager(MoviePlusContext context, string issuer, string secretKey)
        {
            _context = context;
            _issuer = issuer;
            _secretKey = secretKey;
        }

        public string MakeToken(string username, string password)
        {
            //Trazimo da li postoji user sa prosledjenim email i sifrom
            var user = _context.Users.Include(u => u.UserUseCases).FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user == null)
            {
                return null;
            }

            var actor = new JwtActor
            {
                id = user.Id,
                Identity = user.Email,
                AllowedUseCases = user.UserUseCases.Select(x => x.UseCaseId)

            };
            //Predstavlja onog ko izdaje token tj. nas
            var issuer = _issuer;

            var secretKey = _secretKey;
            var claims = new List<Claim> // Jti : "", 
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString(), ClaimValueTypes.String, issuer),
                new Claim(JwtRegisteredClaimNames.Iss, "asp_api", ClaimValueTypes.String, issuer),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64, issuer),
                new Claim("UserId", actor.id.ToString(), ClaimValueTypes.String, issuer),
                new Claim("ActorData",JsonConvert.SerializeObject(actor), ClaimValueTypes.String, issuer)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var now = DateTime.UtcNow;
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: "Any",
                claims: claims,
                notBefore: now,
                expires: now.AddSeconds(3600),//Vreme trajanja tokena u sekundama
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

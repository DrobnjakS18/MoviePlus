﻿using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MoviePlus.DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
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
            var md5 = MD5.Create();
            
                byte[] passwordBytes = Encoding.ASCII.GetBytes(password);

                byte[] hash = md5.ComputeHash(passwordBytes);

                var stringBuilder = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                    stringBuilder.Append(hash[i].ToString("X2"));

                var hashedPassword =  stringBuilder.ToString();

            //Trazimo da li postoji user sa prosledjenim email i sifrom
            var user = _context.Users.Include(u => u.UserUseCases).FirstOrDefault(x => x.Username == username && x.Password == hashedPassword);

            if (user == null)
            {
                return null;
            }

            var actor = new JwtActor
            {
                id = user.Id,
                Identity = user.Username,
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
                expires: now.AddHours(2),//Vreme trajanja tokena
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

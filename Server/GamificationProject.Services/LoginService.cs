using GamificationProject.Data;
using GamificationProject.Helpers;
using GamificationProject.Interfaces;
using GamificationProject.Server.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace GamificationProject.Services
{
    public class LoginService : ILoginService
    {
        private readonly UserService _UserService;

        public LoginService(UserService userService)
        {
            _UserService = userService;
        }

        public AuthenticatedUser GetUser(int userId)
        {
            AuthenticatedUser authenticatedUser = null;

            var user = _UserService.GetDetailed(userId);

            if (user != null)
            {
                authenticatedUser = new AuthenticatedUser();
                authenticatedUser.Id = user.Id;
                authenticatedUser.Username = user.Username;
                authenticatedUser.Admin = user.Admin;
                //authenticatedUser.Permission = user.Permission;
            }

            return authenticatedUser;
        }

        public AuthenticatedUser Login(AuthenticationRequest entity)
        {
            AuthenticatedUser authenticatedUser = null;

            var user = _UserService.Get(e => e.Username == entity.Username).FirstOrDefault();

            if (user != null && PasswordHelper.ValidatePass(new User() { Password = user.Password }, entity.Password))
            {
                //var tokenHandler = new JwtSecurityTokenHandler();
                //var key = Encoding.ASCII.GetBytes("piki");
                //var tokenDescriptor = new SecurityTokenDescriptor
                //{
                //    //Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, user.Id.ToString()) }),
                //    Expires = DateTime.UtcNow.AddDays(1),
                //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                //};
                //var token = tokenHandler.CreateToken(tokenDescriptor);

                authenticatedUser = new AuthenticatedUser();
                authenticatedUser.Id = user.Id;
                authenticatedUser.Username = user.Username;
                authenticatedUser.Admin = user.Admin;
                //authenticatedUser.Token = tokenHandler.WriteToken(token);
                //authenticatedUser.Permission = user.Permission;
            }

            return authenticatedUser;
        }
    }
}

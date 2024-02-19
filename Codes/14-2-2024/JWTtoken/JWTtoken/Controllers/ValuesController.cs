using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;


namespace JWTtoken.Controllers
{
    public class KeyGenerator

    {

        public static string GenerateRandomKey(int lengthInBytes)

        {

            byte[] randomBytes = new byte[lengthInBytes];

            using (var rng = new RNGCryptoServiceProvider())

            {

                rng.GetBytes(randomBytes);

            }

            return Convert.ToBase64String(randomBytes);

        }

    }

    public class ValuesController : ApiController
    {

        public object GetToken()
        {
            string key = "jawt_11233224141241214155513151311111111111";
            var issuer = "http://mysite.com";
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>();   // info about user encoded in form of security token
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim("valid", "1"));
            claims.Add(new Claim("userid", "1"));
            claims.Add(new Claim("name", "Geetha"));

            var token = new JwtSecurityToken(issuer,
                issuer,
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);
            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);
            return new { data = jwt_token };
        }

        [HttpPost]
        public String GetName1()
        {
            if (User.Identity.IsAuthenticated)
            {
                var identity = User.Identity as ClaimsIdentity;
                if (identity != null)
                {
                    IEnumerable<Claim> claims = identity.Claims;
                }
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }

        [Authorize]
        [HttpPost]
        public Object GetName2()
        {
            var identity = User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;
                var name = claims.Where(p => p.Type == "name").FirstOrDefault()?.Value;
                return new
                {
                    data = name
                };

            }

            return null;
        }





        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

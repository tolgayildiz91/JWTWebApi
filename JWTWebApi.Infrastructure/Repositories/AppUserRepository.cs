using JWTWebApi.Domain.Entities.Concrete;
using JWTWebApi.Domain.Interfaces;
using JWTWebApi.Infrastructure.Context;
using JWTWebApi.Infrastructure.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JWTWebApi.Infrastructure.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        readonly ApplicationDbContext _dbContext;
        readonly IOptions<AppSettings> _appSettings;
        public AppUserRepository(ApplicationDbContext dbContext,IOptions<AppSettings> appSettings)
        {
            _dbContext = dbContext;
            _appSettings = appSettings;
        }
        public async Task Add(AppUser item)
        {
           var dbItem= await _dbContext.Users.Where(x => x.UserName == item.UserName).FirstOrDefaultAsync();
            if (dbItem==null)
            {
               await _dbContext.Users.AddAsync(item);
               await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Bu Kullanıcı Adı Veritabenında Var...");
            }


        }

        public Task<AppUser> Authentication(string userName, string password)
        {
            var user = _dbContext.Users.SingleOrDefaultAsync(x => x.UserName == userName && x.Password == password);
            if (user!=null)
            {
                //Token -> bilet, user giriş işlemleri web projelerinde mantıklı olsada api de mantıklı değildir. bu yüzden sisteme gelen kullanıcı birkere kontrol edilir sonra o kullanıcı için bilet oluşturulur ve kullanıcı bilet ile yoluna devam eder.

                var tokenHandler = new JwtSecurityTokenHandler();//Token oluşturmak için kullanılan sınıf,token belirlenen ayarlara göre oluştururlur.
                var key = Encoding.ASCII.GetBytes(_appSettings.Value.SecretKey); //appsettings.json içerisinde belirlediğimiz bir değer. bunun için bir genarator kullanılabilir.
                var tokenDescriptor = new SecurityTokenDescriptor()
                {
                    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[] {

                        new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                user.Result.Token = tokenHandler.WriteToken(token);
            }
                return user;


        }

        public Task Delete(AppUser item)
        {
            throw new NotImplementedException();
        }

        public Task Edit(AppUser item)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppUser>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

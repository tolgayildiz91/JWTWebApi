using JWTWebApi.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTWebApi.Domain.Interfaces
{
    public interface IAppUserRepository:IBaseRepository<AppUser>
    {
       Task<AppUser> Authentication(string userName, string password);
    }
}

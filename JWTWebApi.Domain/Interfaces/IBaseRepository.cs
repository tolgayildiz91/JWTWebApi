using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTWebApi.Domain.Interfaces
{
    public interface IBaseRepository<T> where T:class
    {
        Task Add(T item);
        Task Edit(T item);

        Task Delete(T item);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();

    }
}

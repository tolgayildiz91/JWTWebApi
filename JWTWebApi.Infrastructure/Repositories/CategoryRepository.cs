using JWTWebApi.Domain.Entities.Concrete;
using JWTWebApi.Domain.Interfaces;
using JWTWebApi.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTWebApi.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
      readonly ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(Category item)
        {
            try
            {
              await  _dbContext.Categories.AddAsync(item);
              await  _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Ekleme İşlemi Sırasında Bir Hata İle Karşılaşıldı.");
            }
                
        }
        public async Task Delete(Category item)
        {
            try
            {
                item.Status = Domain.Enums.Status.Deleted;
                await Edit(item);
            }
            catch (Exception)
            {

                throw new Exception("Silme İşlemi Yapılırken Bir Hata İle Karşılaşıldı.");
            }
        }

        public async Task Edit(Category item)
        {
            try
            {
                _dbContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception("Güncelleme İşlemi Yapılırken Bir Hata İle Karşılaşıldı.");
            }

        }

        public async Task<List<Category>> GetAll()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return await _dbContext.Categories.FindAsync(id);
        }
    }
}

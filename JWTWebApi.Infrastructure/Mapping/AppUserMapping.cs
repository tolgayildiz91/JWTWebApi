using JWTWebApi.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTWebApi.Infrastructure.Mapping
{
    public class AppUserMapping : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {

            builder.Property(x => x.UserName).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.HasData(

                new AppUser() { Id = 1, UserName = "rido", Password = "123", CreatedBy = "sysAdmin", CreatedDate = DateTime.Now, Status = Domain.Enums.Status.Active },
                new AppUser() { Id = 2, UserName = "onder", Password = "123", CreatedBy = "sysAdmin", CreatedDate = DateTime.Now, Status = Domain.Enums.Status.Active },
                new AppUser() { Id = 3, UserName = "pelin", Password = "123", CreatedBy = "sysAdmin", CreatedDate = DateTime.Now, Status = Domain.Enums.Status.Active }
                );
        }
    }
}

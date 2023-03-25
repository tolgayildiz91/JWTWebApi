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
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(100).IsRequired();

            builder.HasData(
                new Category() {Id=1,Name="Gıda",Description="sebze",CreatedBy="sysAdmin",CreatedDate=DateTime.Now,Status=Domain.Enums.Status.Active },
                new Category() {Id=2,Name="Teknoloji",Description="pc,tablet",CreatedBy="sysAdmin",CreatedDate=DateTime.Now,Status=Domain.Enums.Status.Active },
                new Category() {Id=3,Name="Aksesuar",Description="takı toka",CreatedBy="sysAdmin",CreatedDate=DateTime.Now,Status=Domain.Enums.Status.Active }

                );
        }
    }
}

using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder
                  .HasKey(key => key.IdDoctor);
            builder
                 .Property(e => e.FirstName)
                 .HasMaxLength(100);
            builder
                 .Property(e => e.LastName)
                 .HasMaxLength(100);
            builder
                .Property(e => e.Email)
                .HasMaxLength(100);

            var dictDoctors = new List<Doctor>();
            dictDoctors.Add(new Doctor { IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jjk1jkj@nn.com" });
            dictDoctors.Add(new Doctor { IdDoctor = 2, FirstName = "Andrzej", LastName = "Andrzejewski", Email = "jjkjk2j@nn.com" });
            dictDoctors.Add(new Doctor { IdDoctor = 3, FirstName = "Alla", LastName = "Bogusla", Email = "jjk3jkj@nn.com" });
            dictDoctors.Add(new Doctor { IdDoctor = 4, FirstName = "Michał", LastName = "Makieda", Email = "jjk4jkj@nn.com" });
            dictDoctors.Add(new Doctor { IdDoctor = 5, FirstName = "Maciej", LastName = "Maciejewski", Email = "j5jk4jkj@nn.com" });

            builder.HasData(dictDoctors);
        }
    }
}


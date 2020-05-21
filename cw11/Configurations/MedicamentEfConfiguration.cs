using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder
                .HasKey(key => key.IdMedicament);
            builder
                .Property(e => e.Name).HasMaxLength(100);
            builder
                .Property(e => e.Description).HasMaxLength(100);
            builder
                .Property(e => e.Type).HasMaxLength(100);

            var dictMedicaments = new List<Medicament>();
            dictMedicaments.Add(new Medicament { IdMedicament = 1, Name = "Aaaaa", Description = "Good", Type = "t" });
            dictMedicaments.Add(new Medicament { IdMedicament = 2, Name = "Bbbbbb", Description = "Bad", Type = "c" });
            dictMedicaments.Add(new Medicament { IdMedicament = 3, Name = "Cccccc", Description = "Noramal", Type = "k" });
            dictMedicaments.Add(new Medicament { IdMedicament = 4, Name = "Ddddd", Description = "Bad", Type = "h" });
            dictMedicaments.Add(new Medicament { IdMedicament = 5, Name = "Eeeeeee", Description = "Noramal", Type = "k" });


            builder.HasData(dictMedicaments);
        }

    }
}

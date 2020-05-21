using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class Prescription_MedicamentEfConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder
                .HasKey(key => new { key.IdMedicament, key.IdPrescription });
            builder
                .HasOne(e => e.Prescription)
                .WithMany()
                .HasForeignKey(e => e.IdPrescription);
            builder
                .HasOne(e => e.Medicament)
                .WithMany()
                .HasForeignKey(e => e.IdMedicament);
            builder
                .Property(e => e.Dose)
                .IsRequired();
            builder
                .Property(e => e.Details)
                .HasMaxLength(100);

            var dict = new List<Prescription_Medicament>(); 
            dict.Add(new Prescription_Medicament { IdMedicament = 3, IdPrescription = 1, Dose = 1, Details = "details" });
            dict.Add(new Prescription_Medicament { IdMedicament = 5, IdPrescription = 2, Dose = 2, Details = "detailsdetails" });
            dict.Add(new Prescription_Medicament { IdMedicament = 4, IdPrescription = 3, Dose = 3, Details = "detailsdetailsdetails" });
            dict.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 4, Details = "detailsdetailsdetailsdetails" });
            dict.Add(new Prescription_Medicament { IdMedicament = 5, IdPrescription = 4, Dose = 5, Details = "detailsdetailsdetailsdetailsdetails" });


            builder.HasData(dict);
        }
    }
}


using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder
                .HasKey(key => key.IdPrescription);
            builder
                .HasOne(e => e.Patient)
                .WithMany()
                .HasForeignKey(e => e.IdPatient);
            builder
                .HasOne(e => e.Doctor)
                .WithMany()
                .HasForeignKey(e => e.IdDoctor);

            var dictPrescription = new List<Prescription>();
            dictPrescription.Add(new Prescription { IdPrescription = 1, Date = Convert.ToDateTime("2010-03-06"), DueDate = Convert.ToDateTime("2011-01-07"), IdPatient = 1, IdDoctor = 1 });
            dictPrescription.Add(new Prescription { IdPrescription = 2, Date = Convert.ToDateTime("2014-09-01"), DueDate = Convert.ToDateTime("2015-11-07"), IdPatient = 2, IdDoctor = 2 });
            dictPrescription.Add(new Prescription { IdPrescription = 3, Date = Convert.ToDateTime("2016-02-04"), DueDate = Convert.ToDateTime("2016-07-17"), IdPatient = 3, IdDoctor = 3 });
            dictPrescription.Add(new Prescription { IdPrescription = 4, Date = Convert.ToDateTime("2018-01-02"), DueDate = Convert.ToDateTime("2019-08-27"), IdPatient = 4, IdDoctor = 4 });
            dictPrescription.Add(new Prescription { IdPrescription = 5, Date = Convert.ToDateTime("2020-05-05"), DueDate = Convert.ToDateTime("2021-04-12"), IdPatient = 5, IdDoctor = 5 });


            builder.HasData(dictPrescription);
        }

    }
}

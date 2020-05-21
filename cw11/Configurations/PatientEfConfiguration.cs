using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder
                .HasKey(key => key.IdPatient);
            builder
                .Property(e => e.FirstName)
                .HasMaxLength(100);
            builder
                .Property(e => e.LastName)
                .HasMaxLength(100);

            var dictPatients = new List<Patient>();
            dictPatients.Add(new Patient { IdPatient = 1, FirstName = "Antoni", LastName = "Baka", Birthdate = Convert.ToDateTime("1980-03-01") });
            dictPatients.Add(new Patient { IdPatient = 2, FirstName = "Krzystof", LastName = "Rybka", Birthdate = Convert.ToDateTime("1999-02-10") });
            dictPatients.Add(new Patient { IdPatient = 3, FirstName = "Anna", LastName = "Manowska", Birthdate = Convert.ToDateTime("1986-07-06") });
            dictPatients.Add(new Patient { IdPatient = 4, FirstName = "Jakub", LastName = "Byk", Birthdate = Convert.ToDateTime("1998-02-10") });
            dictPatients.Add(new Patient { IdPatient = 5, FirstName = "Anna", LastName = "Cholewska", Birthdate = Convert.ToDateTime("1986-07-06") });

            builder.HasData(dictPatients);
        }
    }
}

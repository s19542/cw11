using cw11.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class HospitalDbContext : DbContext
    {

        public HospitalDbContext() { }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
        : base(options)
        {


        }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Prescription> Prescription { get; set; }
        public virtual DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Medicament> Medicament { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                  .ApplyConfiguration(new MedicamentEfConfiguration());

            modelBuilder
                .ApplyConfiguration(new DoctorEfConfiguration());
            modelBuilder
                .ApplyConfiguration(new PatientEfConfiguration());
            modelBuilder
                .ApplyConfiguration(new PrescriptionEfConfiguration());
            modelBuilder
                .ApplyConfiguration(new Prescription_MedicamentEfConfiguration());


        }



    }
}

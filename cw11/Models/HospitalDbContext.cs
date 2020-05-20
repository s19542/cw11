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
         public virtual DbSet <Doctor> Doctors { get; set; } 
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }

       

    }
}

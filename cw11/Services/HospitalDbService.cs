using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public class HospitalDbService : IHospitalDbService
    {
        private readonly HospitalDbContext hospitalDbContext;
        public void Add(Doctor doctor)
        {
            hospitalDbContext.Doctor.Add(doctor);
            hospitalDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var doctor = hospitalDbContext
                .Doctor
                .FirstOrDefault(e => e.IdDoctor == id);
            hospitalDbContext.Remove(doctor);
            hospitalDbContext.SaveChanges();
        }

        public Doctor Get(int id)
        {
            return hospitalDbContext.Doctor.First(doctor => doctor.IdDoctor == id);
            
        }

        public void Modify(Doctor doctor)
        {
            var newDoc = hospitalDbContext
                .Doctor
                .FirstOrDefault(e => e.IdDoctor == doctor.IdDoctor);
            newDoc.FirstName = doctor.FirstName;
            newDoc.LastName = doctor.LastName;
            newDoc.Email = doctor.Email;
            hospitalDbContext.SaveChanges();
        }
    }
}

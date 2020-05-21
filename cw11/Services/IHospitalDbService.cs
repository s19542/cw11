using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IHospitalDbService
    {
        public Doctor Get(int id);
        public void Add(Doctor doctor);
        public void Delete(int id);
        public void Modify(Doctor doctor);
    }
}

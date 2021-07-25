using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine.Services
{
    public interface IMedicineService
    {
        public bool addMedicine(Models.Medicine medicine);

        public List<Models.Medicine> getMedicines();

        public Models.Medicine getMedicineById(int id);

        public bool updateMedicine(Models.Medicine medicine);

        public bool deleteMedicine(int id);
    }
}

using Medicine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine.Services
{
    public class MedicineService : IMedicineService
    {

        MedStoreMedicineDBContext context = null;

        public MedicineService()
        {
            context = new MedStoreMedicineDBContext();
        }
        public bool addMedicine(Models.Medicine medicine)
        {
            context.Medicines.Add(medicine);
            context.SaveChanges();
            return true;
        }

        public bool deleteMedicine(int id)
        {

            Models.Medicine medicine = context.Medicines.Find(id);
            context.Medicines.Remove(medicine);
            context.SaveChanges();
            return true;
        }

        public Models.Medicine getMedicineById(int id)
        {
            Models.Medicine medicine = context.Medicines.Find(id);
            return medicine;  
        }

        public List<Models.Medicine> getMedicines()
        {
            List<Models.Medicine> medicineList = context.Medicines.ToList();
            return medicineList;
        }

        public bool updateMedicine(Models.Medicine medicine)
        {
            context.Medicines.Update(medicine);
            context.SaveChanges();
            return true;
        }
    }
}

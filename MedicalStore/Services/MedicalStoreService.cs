using MedicalStore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Services
{
    public class MedicalStoreService : IMedicalStoreService
    {
        MedicalStoreDBContext context = null;

        public MedicalStoreService()
        {
            context = new MedicalStoreDBContext();
        }

        public bool addStore(Entities.MedicalStore medicalStore)
        {
            context.MedicalStores.Add(medicalStore);
            context.SaveChanges();
            return true;
        }

        public bool deleteStore(int id)
        {
            Entities.MedicalStore store = context.MedicalStores.Find(id);
            context.MedicalStores.Remove(store);
            context.SaveChanges();
            return true;
        }

        public Entities.MedicalStore getStoreById(int id)
        {
            Entities.MedicalStore store = context.MedicalStores.Find(id);
            return store;
        }

        public List<Entities.MedicalStore> getStores()
        {
            List<Entities.MedicalStore> medicalStores = context.MedicalStores.ToList();
            return medicalStores;
        }

        public bool updateStore(Entities.MedicalStore medicalStore)
        {
            context.MedicalStores.Update(medicalStore);
            context.SaveChanges();
            return true;
        }
    }
}

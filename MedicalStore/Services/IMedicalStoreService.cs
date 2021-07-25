using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Services
{
    public interface IMedicalStoreService
    {

        public bool addStore(Entities.MedicalStore medicalStore);

        public List<Entities.MedicalStore> getStores();

        public Entities.MedicalStore getStoreById(int id);

        public bool updateStore(Entities.MedicalStore medicalStore);

        public bool deleteStore(int id);

    }
}

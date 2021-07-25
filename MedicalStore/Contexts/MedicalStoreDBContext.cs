using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Contexts
{
    public class MedicalStoreDBContext:DbContext
    {
        public DbSet<Entities.MedicalStore> MedicalStores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source= .;Initial Catalog=MedStoreDB;Integrated Security=True");
        }

    }
}

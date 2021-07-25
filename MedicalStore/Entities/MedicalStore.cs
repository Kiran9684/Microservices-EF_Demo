using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MedicalStore.Entities
{
    public class MedicalStore
    {
        [Key]
        public int StoreId { get; set; }
        [Required][StringLength(20)]
        public string Name { get; set; }

        [Required][StringLength(20)]
        public string Location { get; set; }
        public int Pincode { get; set; }
    }
}

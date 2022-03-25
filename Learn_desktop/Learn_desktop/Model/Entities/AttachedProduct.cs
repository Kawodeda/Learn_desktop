using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class AttachedProduct
    {
        public int MainProductID { get; set; }
        public int AttachedProductID { get; set; }
        [NotMapped]
        public Product MainProduct { get; set; }
        [NotMapped]
        public Product Product { get; set; }
    }
}

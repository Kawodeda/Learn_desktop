using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        [NotMapped]
        public ICollection<Product> Product { get; set; }
    }
}

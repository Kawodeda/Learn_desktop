using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public string? Description { get; set; }
        public byte[]? MainPhoto { get; set; }
        public bool IsActive { get; set; }
        public int? ManufacturerID { get; set; }
        [NotMapped]
        public Manufacturer Manufacturer { get; set; }
        [NotMapped]
        public ICollection<ProductPhoto> ProductPhoto { get; set; }
        [NotMapped]
        public ICollection<AttachedProduct> AttachedProduct { get; set; }
        [NotMapped]
        public ICollection<ProductSale> ProductSale { get; set; }
    }
}

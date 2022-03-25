using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class ServicePhoto
    {
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public byte[] Photo { get; set; }
        public Service Service { get; set; }
    }
}

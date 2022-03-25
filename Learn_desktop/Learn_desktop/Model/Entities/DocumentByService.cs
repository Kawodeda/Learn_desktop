using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class DocumentByService
    {
        public int ID { get; set; }
        public int ClientServiceID { get; set; }
        public string DocumentPath { get; set; }
        public ClientService ClientService { get; set; }
    }
}

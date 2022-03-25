using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class TagOfClient
    {
        public int ClientID { get; set; }
        public int TagID { get; set; }
        public Client Client { get; set; }
        public Tag Tag { get; set; }
    }
}

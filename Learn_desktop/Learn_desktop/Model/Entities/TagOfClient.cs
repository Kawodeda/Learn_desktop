using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    [Keyless]
    public class TagOfClient
    {
        public int ClientID { get; set; }
        public int TagID { get; set; }
        [NotMapped]
        public Client Client { get; set; }
        [NotMapped]
        public Tag Tag { get; set; }
    }
}

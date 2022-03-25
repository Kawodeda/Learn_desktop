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
    public class Gender
    {
        public string Code { get; set; }
        public string? Title { get; set; }
        [NotMapped]
        public ICollection<Client> Client { get; set; }
    }
}

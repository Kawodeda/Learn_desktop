using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class Tag
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        [NotMapped]
        public ICollection<TagOfClient> TagOfClient { get; set; }
    }
}

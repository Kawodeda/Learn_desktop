using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_desktop.Model.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; }
        public string GenderCode { get; set; }
        public byte[]? Photo { get; set; }
        [NotMapped]
        public Gender Gender { get; set; }
        [NotMapped]
        public ICollection<ClientService> ClientService { get; set; }
        [NotMapped]
        public ICollection<TagOfClient> TagOfClient { get; set; }
    }
}

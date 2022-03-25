using System;
using System.Collections.Generic;
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
        public Gender Gender { get; set; }
        public ICollection<ClientService> ClientService { get; set; }
        public ICollection<TagOfClient> TagOfClient { get; set; }
    }
}

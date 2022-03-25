using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_desktop.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Learn_desktop.Model.DBAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AttachedProduct> AttachedProduct { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ClientService> ClientService { get; set; }
        public DbSet<DocumentByService> DocumentByService { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductPhoto> ProductPhoto { get; set; }
        public DbSet<ProductSale> ProductSale { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServicePhoto> ServicePhoto { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<TagOfClient> TagOfClient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=192.168.12.164;Database=user04;User=user04;Password=93499");
        }
    }
}

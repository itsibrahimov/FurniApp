using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context :DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<MailSubscribe> MailSubscribes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<OurTeam> OurTeams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataAccessLayer.Model;

namespace DataAccessLayer.Model
{
    public partial class PlaybuhEntities : DbContext
    {
        public PlaybuhEntities()
            : base("name=PlaybuhEntities")
        {
        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }*/

        //public DbSet<Contragent> Contragent { get; set; }
        public DbSet<Employee> Employee { get; set; }
        /*public DbSet<Operation> Operation { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Subitem> Subitem { get; set; }
        public DbSet<Taxrate> Taxrate { get; set; }*/
    }
}

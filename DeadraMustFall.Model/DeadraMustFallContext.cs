using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.Domains;
using DeadraMustFall.Model.Domains.Mappings;

namespace DeadraMustFall.Model
{
    public class DeadraMustFallContext:DbContext
    {
        public DeadraMustFallContext() : base("name=DeadraMustFallDBConnectionString")
        {
            
            
            Database.SetInitializer<DeadraMustFallContext>(new DropCreateDatabaseIfModelChanges<DeadraMustFallContext>());
            
            Database.Initialize(true);
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ItemMap());
            //base.OnModelCreating(modelBuilder);
        }
    }
}

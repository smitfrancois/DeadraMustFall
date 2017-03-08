using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model
{
    internal class UserMap : EntityTypeConfiguration<User>
    {
        internal UserMap()
        {
            HasKey(x => x.UserId);
            ToTable("Users");

          
        }
    }
}

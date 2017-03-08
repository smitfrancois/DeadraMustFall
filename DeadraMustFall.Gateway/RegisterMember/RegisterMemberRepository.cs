using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Gateway.baseClasses;
using DeadraMustFall.Model;

namespace DeadraMustFall.Gateway.RegisterMember
{
    public class RegisterMemberRepository : RepositoryBase<DeadraMustFallContext>
    {
        public void AddNewMember(Member newUser)
        {
            DbContext.Users.Add(newUser);
            DbContext.SaveChanges();
        }
    }

    
}

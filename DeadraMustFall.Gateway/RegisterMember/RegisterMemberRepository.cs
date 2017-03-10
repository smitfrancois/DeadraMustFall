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
        public Member AddNewMember(Member newUser)
        {
            User user = new User();

            user.ESOHandle =newUser.ESOHandle;
            user.EmailAddress = newUser.EmailAddress;
            user.Password = newUser.Password;

            DbContext.Users.Add(user);
            DbContext.SaveChanges();

            newUser.UserId = user.UserId;

            return newUser;
        }
    }

    
}

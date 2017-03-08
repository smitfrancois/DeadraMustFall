using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model
{
    public class User
    {
        public Int64 UserId { get; set; }
        public string ESOHandle { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}

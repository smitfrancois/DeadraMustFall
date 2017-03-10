using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Gateway.baseClasses;
using DeadraMustFall.Model.Interfaces;

namespace DeadraMustFall.Gateway.RegisterMember
{
    public class MemberApiResponse:ApiResponseBase
    {
        public override IDBEntity Entity { get; set; }
    }
}

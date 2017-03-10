using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DeadraMustFall.Gateway.RegisterMember;
using Newtonsoft.Json;

namespace DeadraMustFall.API.Controllers
{
    [RoutePrefix("Member")]
    public class MemberController : ApiController
    {
        [Route("AddMember")]
        [HttpPost]
        public string AddNewMember([FromBody] string newMember)
        {
            var member = JsonConvert.DeserializeObject<Member>(newMember);
            RegisterMemberRepository repo = new RegisterMemberRepository();
            member = repo.AddNewMember(member);
            return JsonConvert.SerializeObject(member);
        }
    }
}

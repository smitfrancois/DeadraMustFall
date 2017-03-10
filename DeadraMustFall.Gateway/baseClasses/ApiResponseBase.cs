using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Gateway.interfaces;
using DeadraMustFall.Model.Interfaces;

namespace DeadraMustFall.Gateway.baseClasses
{
    public abstract class ApiResponseBase:IApiResponse
    {
        public abstract IDBEntity Entity { get; set; }
    }
}

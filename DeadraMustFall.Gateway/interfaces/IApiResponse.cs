using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.Interfaces;

namespace DeadraMustFall.Gateway.interfaces
{
    public interface IApiResponse
    {
        IDBEntity Entity { get; set; }

    }
}

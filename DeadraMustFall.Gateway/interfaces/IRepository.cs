using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Gateway.interfaces
{
    public interface IRepository<T>
    {
        T DbContext { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Gateway.interfaces;

namespace DeadraMustFall.Gateway.baseClasses
{
    public abstract class RepositoryBase<T>:IRepository<T> where T:class, new()
    {
        public RepositoryBase()
        {
            DbContext = new T();
        }
        public T DbContext { get; }
    }
}

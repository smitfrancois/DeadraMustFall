﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model.Domains
{
    public class Class
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Skills> Skills { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Api.Entity
{
    public class Permissions
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int State { get; set; }
    }
}

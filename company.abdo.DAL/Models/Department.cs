﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company.abdo.DAL.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string Name { get; set; }

        public DateTime CreateAt { get; set; }

    }
}

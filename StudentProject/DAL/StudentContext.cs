﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BOL;

namespace DAL
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("StudentDB")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}

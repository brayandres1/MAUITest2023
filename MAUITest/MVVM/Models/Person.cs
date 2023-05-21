﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITest.MVVM.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsMarried { get; set; }

        public DateTime BirthDate { get; set; }

        public int Weigth { get; set; }

        public TimeSpan LunchTime { get; set; }
    }
}
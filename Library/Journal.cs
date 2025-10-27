﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKnP231.Library
{
    public class Journal : Literature, IPeriodic
    {
        public String Number { get; set; } = null!;
        public int Year { get; set; }

        public override string GetCard()
        {
            return $"{base.Title} {this.Number} ({Year}) ({base.Publisher})";
        }

        public string GetPeriod()
        {
            return "Місяць";
        }

        [ApaStyle]
        public string ApaCard()
        {
            return $"{base.Publisher} ({this.Year}). {base.Title}, {this.Number}";
        }
    }
}

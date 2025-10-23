﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SharpKnP231.Library
{
    public class Newspaper : Literature
    {
        public DateOnly Date { get; set; }

        public override string GetCard()
        {
            return $"{base.Title} ({base.Publisher}) - {this.Date}";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKnP231.Library
{
    public class Journal : Literature
    {
        public String Number { get; set; } = null!;

        public override string GetCard()
        {
            return $"{base.Title} {this.Number} ({base.Publisher})";
        }
    }
}

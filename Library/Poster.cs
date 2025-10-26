﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKnP231.Library
{
    public class Poster : Literature, INonPrintable
    {
        public DateOnly Date { get; set; }

        public override string GetCard()
        {
            return $"{base.Publisher} - {base.Title} - {this.Date}";
        }
    }
}

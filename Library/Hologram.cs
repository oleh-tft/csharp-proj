﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKnP231.Library
{
    public class Hologram : Literature, INonPrintable
    {
        public String ArtItem { get; set; } = null!;

        public override string GetCard()
        {
            return $"{Title}: Hologram of {ArtItem} by {Publisher}";
        }
    }
}

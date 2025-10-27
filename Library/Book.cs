using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKnP231.Library
{
    public class Book : Literature
    {
        public String Author { get; set; } = null!;
        public int Year { get; set; }

        public override string GetCard()
        {
            return $"{this.Author}. {base.Title} - {base.Publisher} - {this.Year}";
        }

        [ApaStyle]
        public string ApaCard()
        {
            return $"{this.Author} ({this.Year}) {base.Title}. {base.Publisher}";
        }
    }
}

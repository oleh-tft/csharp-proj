using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKnP231.Library
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CiteStyleAttribute : Attribute
    {
        public String Style { get; set; } = null!;
    }
}

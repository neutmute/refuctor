using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuctor.Xml
{
    public class Server
    {
        public string Name { get; set; }

        public string IpAddress { get; set; }

        public string Group { get; set; }

        public string Tag { get; set; }

        public override string ToString()
        {
            return $"Name={Name}, Ip={IpAddress}, Group={Group}, Tag={Tag}";
        }
    }
}

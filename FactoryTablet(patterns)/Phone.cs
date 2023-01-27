using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTablet_patterns_
{
    public class Phone : IDevice
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Screen { get; set; }
        public string Body { get; set; }


       public bool IsDefective { get; set; }
    }
}

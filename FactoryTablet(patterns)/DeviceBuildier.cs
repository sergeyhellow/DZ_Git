using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTablet_patterns_
{

    
    public abstract class DeviceBuildier
    {

        public IDevice Device { get; private set; }   
            public DeviceBuildier(IDevice device)
        {
            Device = device;
        }

        public abstract void SetName(string name);
        public abstract void SetModel(string model);
        public abstract void SetScreen(string screnn);
        public abstract void SetBody(string Body);
     

    }
}

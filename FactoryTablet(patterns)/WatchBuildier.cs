using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTablet_patterns_
{
    public class WatchBuildier:DeviceBuildier
    {



        public WatchBuildier(IDevice device) : base(device)
        {


        }

        public override void SetBody(string str)
        {
            Device.Body = $"{str} Watch Boby";
        }

        public override void SetModel(string str)
        {
            Device.Model = $"{str} Watch Model";
        }

        public override void SetName(string str)
        {
            Device.Name = $"{str} Watch Name";
        }

        public override void SetScreen(string str)
        {
            Device.Screen = $"{str} Watch Screen";
        }


    }
}

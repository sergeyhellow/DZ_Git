using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTablet_patterns_
{
    public class PadBuildier:DeviceBuildier
    {

        public PadBuildier(IDevice device) : base(device)
        {


        }

        public override void SetBody(string str)
        {
            Device.Body = $"{str} Pad Boby";
        }

        public override void SetModel(string str)
        {
            Device.Model = $"{str} Pad Model";
        }

        public override void SetName(string str)
        {
            Device.Name = $"{str} Pad Name";
        }

        public override void SetScreen(string str)
        {
            Device.Screen = $"{str} Pad Screen";
        }

    }
}

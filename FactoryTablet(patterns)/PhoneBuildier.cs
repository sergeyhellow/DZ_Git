using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FactoryTablet_patterns_
{
    public class PhoneBuildier : DeviceBuildier
    {

        public PhoneBuildier (IDevice device):base(device)
        {


        }

        public override void SetBody(string body)
        {
            Device.Body = $"{body} Phone body ";
        }

        public override void SetModel(string name)
        {
            Device.Model = $"{name} Phone Model "; 
        }

        public override void SetName(string name)
        {
            Device.Name = $"{name} Phone Name ";
        }

        public override void SetScreen(string name)
        {
            Device.Screen = $"{name} Phone Screen";
        }
    }
}

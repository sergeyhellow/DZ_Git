using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTablet_patterns_
{
    public class DeviceStorrage
    {
        private DeviceStorrage() { }

        public List<IDevice> devices { get; set; } = new List<IDevice>();
        public static DeviceStorrage Instance { get => DeviceStorrageCreate.instanse; }

        private class DeviceStorrageCreate
        {

            static DeviceStorrageCreate() { }
            internal static readonly DeviceStorrage instanse = new DeviceStorrage();

        }

        public string MakeReport()
        {
            string res = "";
            foreach (var item in devices)
            {

                res += item.Name + " " + item.Model + " " + item.IsDefective.ToString()+ Environment.NewLine;
            }
            return res;

        }
    }
}

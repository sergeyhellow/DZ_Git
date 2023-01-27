using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTablet_patterns_
{
    public class Worker
    {
        public IDevice MakeDevise(DeviceBuildier deviceBuildier, string name, string screen, string model, string body)
        {
           

            deviceBuildier.SetScreen(screen);
            deviceBuildier.SetModel(model);
            deviceBuildier.SetBody(body);
            deviceBuildier.SetName(name);
            DeviceStorrage.Instance.devices.Add(deviceBuildier.Device);
            TestDevices();
            return deviceBuildier.Device;

        }

        public void TestDevices()
        {
            var dev = DeviceStorrage.Instance.devices;
            Random rnd = new Random();

            if (dev.Count % 10 == 0)
            {
                for (int i = dev.Count - 10; i< dev.Count; i++ )
                {
                    if (rnd.Next(0, 16) < 9)
                    {
                        dev[i].IsDefective = false;
                    }
                    else
                    {
                        dev[i].IsDefective = true;
                    }
                
                }
            

            }
        
        
        }


    }
}

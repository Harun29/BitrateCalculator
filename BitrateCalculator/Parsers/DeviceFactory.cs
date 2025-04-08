using BitrateCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Parsers
{
    public static class DeviceFactory
    {
        public static Device FromJson(JsonInput input)
        {
            var nicList = new List<NetworkInterface>();

            foreach (var jsonNic in input.NIC)
            {
                nicList.Add(new NetworkInterface
                {
                    Description = jsonNic.Description,
                    MAC = jsonNic.MAC,
                    Timestamp = DateTime.Parse(jsonNic.Timestamp),
                    Rx = long.Parse(jsonNic.Rx),
                    Tx = long.Parse(jsonNic.Tx),
                });
            }

            return new Device
            {
                DeviceName = input.Device,
                Model = input.Model,
                NICs = nicList
            };
        }
    }
}

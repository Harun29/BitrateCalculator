using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Models
{
    public class Device
    {
        public string DeviceName { get; set; }
        public string Model { get; set; }
        public List<NetworkInterface> NICs { get; set; }
    }
}

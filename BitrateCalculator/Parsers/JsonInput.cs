using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Parsers
{
    public class JsonInput
    {
        public string Device { get; set; }
        public string Model { get; set; }
        public List<JsonNIC> NIC { get; set; }

        public class JsonNIC
        {
            public string Description { get; set; }
            public string MAC { get; set; }
            public string Timestamp { get; set; }
            public string Rx { get; set; }
            public string Tx { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Models
{
    public class BitrateResult
    {
        public double RxBitrate { get; set; }
        public double TxBitrate { get; set; }
        public override string ToString() => $"Rx Bitrate: {RxBitrate} bps\nTx Bitrate: {TxBitrate} bps";
    }
}

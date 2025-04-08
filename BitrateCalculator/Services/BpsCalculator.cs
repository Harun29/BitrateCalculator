using BitrateCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Services
{
    public class BpsCalculator : IBpsCalculator
    {
        public BitrateResult Calculate(NetworkInterface current, NetworkInterface previous, double intervalSeconds)
        {
            return new BitrateResult
            {
                RxBitrate = CalculateBitrate(current.Rx, previous.Rx, intervalSeconds),
                TxBitrate = CalculateBitrate(current.Tx, previous.Tx, intervalSeconds)
            };
        }

        private double CalculateBitrate(long currentValue, long previousValue, double intervalSeconds)
        {
            long difference = currentValue - previousValue;
            return (difference * 8.0) / intervalSeconds;
        }
    }
}

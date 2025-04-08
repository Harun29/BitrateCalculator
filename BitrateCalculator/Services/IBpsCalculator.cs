using BitrateCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Services
{
    public interface IBpsCalculator
    {
        BitrateResult Calculate(NetworkInterface current, NetworkInterface previous, double intervalSeconds);
    }
}

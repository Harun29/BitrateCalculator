using BitrateCalculator.Models;
using BitrateCalculator.Parsers;
using BitrateCalculator.Services;
using System;
using System.IO;
using System.Text.Json;

namespace BitrateCalculator
{
    internal class Program
    {
        const double PollingIntervalSeconds = 0.5;
        const int RxOctetDifference = 16000;
        const int TxOctetDifference = 4000;
        static void Main(string[] args)
        {
            string json = File.ReadAllText("input.json");
            JsonInput parsedJson = JsonSerializer.Deserialize<JsonInput>(json);
            Device device = DeviceFactory.FromJson(parsedJson);

            NetworkInterface currentNIC = device.NICs[0];

            NetworkInterface previousNIC = currentNIC.Clone();
            previousNIC.Timestamp = previousNIC.Timestamp.AddSeconds(-PollingIntervalSeconds);
            previousNIC.Rx -= RxOctetDifference;
            previousNIC.Tx -= TxOctetDifference;

            IBpsCalculator calculator = new BpsCalculator();
            BitrateResult result = calculator.Calculate(currentNIC, previousNIC, PollingIntervalSeconds);

            Console.WriteLine($"Device: {device.DeviceName} ({device.Model})");
            Console.WriteLine($"NIC: {currentNIC.Description} | MAC: {currentNIC.MAC}");
            Console.WriteLine(result);
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}

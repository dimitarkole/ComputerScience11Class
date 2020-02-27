namespace TransportSuytem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var inputTrunks = Console.ReadLine().Split(';');
            var trunks = new List<Truck>();

            foreach (var trunkString in inputTrunks)
            {
                var trunkParamiteres = trunkString.Split('=');
                var trunk = new Truck(trunkParamiteres[0], double.Parse(trunkParamiteres[1]));
                trunks.Add(trunk);
            }

            var inputFreight = Console.ReadLine().Split(';');
            var freights = new List<Freight>();

            foreach (var freightsString in inputFreight)
            {
                var freightsParamiteres = freightsString.Split('=');
                var freight = new Freight(freightsParamiteres[0], double.Parse(freightsParamiteres[1]));
                freights.Add(freight);
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                var data = input.Split(' ');
                var trunkName = data[0];
                var freightName = data[1];

                var trunk = trunks.FirstOrDefault(t => t.Name == trunkName);
                var freight = freights.FirstOrDefault(f => f.Name == freightName);

                trunk.AddFreights(freight);

                input = Console.ReadLine();
            }

            foreach (var truck in trunks)
            {
                Console.WriteLine(truck.ToString());
                Console.WriteLine();
            }
        }
    }
}

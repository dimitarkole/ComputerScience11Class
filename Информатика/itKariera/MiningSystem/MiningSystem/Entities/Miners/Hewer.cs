using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Miners
{
    public class Hewer : Miner
    {
        public int EnduranceFactor { get; set; }
        public Hewer(string id, double coalOutput, double energyRequirement, int enduranceFactor ) 
            : base(id, coalOutput, energyRequirement/ enduranceFactor)
        {
        }
    }
}

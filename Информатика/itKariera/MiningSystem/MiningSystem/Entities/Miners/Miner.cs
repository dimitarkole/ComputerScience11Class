using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Miners
{
    public abstract class Miner
    {
        public string Id  { get; set; }

        public double CoalOutput  { get; set; }

        private double energyRequirement;

        protected Miner(string id, double coalOutput, double energyRequirement)
        {
            Id = id;
            CoalOutput = coalOutput;
            EnergyRequirement = energyRequirement;
        }

        public double EnergyRequirement
        {
            get { return energyRequirement; }
            set {
                if (!(value > 0  && value < 20000)) throw new InvalidOperationException("");
                energyRequirement = value; 
            }
        }
    }
}

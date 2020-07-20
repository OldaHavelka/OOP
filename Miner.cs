using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Miner : Worker
    {
        int ammountOfLegs;
        override public int AmmountOfLegs { get => 3; set { }}
        public Miner() {
            this.ammountOfLegs=AmmountOfLegs;
        }

        public void printAmmountOfLegs() {
            Console.WriteLine("This miner has {0} legs.",this.ammountOfLegs);
        }

        public void addLeg() {
            this.ammountOfLegs++;
        }

        public void addLegAgain()
        {
            this.AmmountOfLegs++;
        }
    }
}

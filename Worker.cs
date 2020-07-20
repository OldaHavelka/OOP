using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Worker : AbHuman, IInterface
    {
        int ammountOfLegs;
        public virtual int AmmountOfLegs { get => this.ammountOfLegs; set { ammountOfLegs=2; }}

        public Worker() {
            this.ammountOfLegs = 2;
        }

        public Worker(int ammountOfLegs) {
            this.ammountOfLegs = ammountOfLegs;
        }
        public void payTheEmployee()
        {
            Console.WriteLine("Employee has been paid.");
        }

        public override void TellMeHowManyLegsDoYouHave()
        {
            Console.WriteLine("I have {0} legs.", this.ammountOfLegs);
        }
    }
}

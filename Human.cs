using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Human
    {
        int ammountOfLegs;

        public Human(int ammountOfLegs)
        {
            this.ammountOfLegs = ammountOfLegs;
        }

        public Human() {
            this.ammountOfLegs = 2;
        }

        public abstract void TellMeHowManyLegsDoYouHave();
    }
}

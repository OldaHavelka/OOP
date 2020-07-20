using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Miner pepa = new Miner();
            pepa.payTheEmployee();
            pepa.printAmmountOfLegs();
            pepa.TellMeHowManyLegsDoYouHave();
            pepa.addLeg();
            pepa.printAmmountOfLegs();
            pepa.TellMeHowManyLegsDoYouHave();
            pepa.addLegAgain();
            pepa.printAmmountOfLegs();
            pepa.TellMeHowManyLegsDoYouHave();

            Console.ReadLine();
        }
    }
}

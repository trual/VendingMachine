using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine VM = new VendingMachine();

            string turnOff = "";

            while (turnOff != "TURN OFF")
            {
                Console.WriteLine(VM.getDisplay());
                string input = Console.ReadLine();
                VM.takeInput(input);
                
                if (VM.getDisplay() == "THANK YOU")
                {
                    Console.WriteLine(VM.getDisplay());
                    Console.ReadLine();
                    VM.updateDisplay();
                }
                if (VM.getDisplay() == "Invalid Input")
                {
                    Console.WriteLine(VM.getDisplay());
                    Console.WriteLine("Coin options : penny, nickel, dime, or quarter");
                    Console.WriteLine("Item Options : cola, candy, chips");
                    Console.WriteLine("RETURN to return coins.");
                    Console.WriteLine("press enter to continue.");
                    Console.ReadLine();
                    VM.updateDisplay();
                }
            }

        }
    }
}

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
            }

        }
    }
}

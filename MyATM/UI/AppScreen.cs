using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyATM.UI
{
    public class AppScreen
    {
        internal static void Welcome()
        {

            Console.Clear();
            //title
            Console.Title = "MyATM ";
            //set forground color white//
            Console.ForegroundColor = ConsoleColor.White;
            //Display welcome message
            Console.WriteLine("\n\n -------------------- Welcome to MyATM -------------");


            //prompt the user to enter ATM card//
            Console.WriteLine("\t\tPlease insert your ATM card \n\n Note :\t\t\n actual ATM machie will accept and validate a physical ATM card, read the card number and validate it");

            Utility.PressEnterToContinue();
        }


    }
}

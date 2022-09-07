using MyATM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyATM.App
{
    class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            MyATM atmApp  = new MyATM();

            atmApp.CheckUserCardNumAndPassword();
            //long cardNumber = Validator.Convert<long>("your card number");
            //Console.WriteLine($"Your card number is {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}

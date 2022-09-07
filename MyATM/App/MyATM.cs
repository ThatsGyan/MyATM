using MyATM.Domain.Entities;
using MyATM.UI;
using System;


namespace MyATM.App
{

   
     class MyATM
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>();
            new UserAccount { Id = 1, FullName = "Gyan Rajput", AccountNumber = 123456, CardNumber = 123123, AccountBalance = 5000.00m, IsLocked = false };
            new UserAccount { Id = 1, FullName = "Rahul Jangid", AccountNumber = 123457, CardNumber = 123124, AccountBalance = 4000.00m, IsLocked = false };
            new UserAccount { Id = 1, FullName = "Mudit Sharma", AccountNumber = 123458, CardNumber = 123125, AccountBalance = 3000.00m, IsLocked = false };
            new UserAccount { Id = 1, FullName = "Aditya verma", AccountNumber = 123459, CardNumber = 1231236, AccountBalance = 2000.00m, IsLocked = false };
        }

        internal void CheckUserCardNumAndPassword()
        {
            throw new NotImplementedException();
        }
    }
    public void CheckUserCardNumAndPassword()
    {
        bool isCorrectLogin = false;

        UserAccount tempUserAccount = new UserAccount();

        tempUserAccount.CardNumber = Validator.Convert<long>("Your card number");
        tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter Your Card PIN"));

        Console.WriteLine("Checking card number and PIN...");
        int timer = 10;

        for (int i = 0; i < timer; i++)
        {
            Console.WriteLine(".");
            Thread.Sleep(200);

            Console.Clear();
        }
    }
}
using MyATM.Domain.Entities;
using MyATM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyATM.Domain.Interfaces
{
    public interface IUserLogin
    {
        void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;

            UserAccount tempUserAccount = new UserAccount();
            tempUserAccount.CardNumber = Validator.Convert<long>("Your Card Number");
            tempUserAccount.CardPin = 
        }
    }
}

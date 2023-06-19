using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module17_Refactoring
{
    class Calculator
    {
        // Метод для расчета процентной ставки
        public double CalculateInterest(IAccountProfile accountProfile,Account account)
        {
            account.Interest = accountProfile.CalculateInterest(account.Balance);
            return account.Interest;
            //if (account.Type == "Обычный")
            //{
                // расчет процентной ставки обычного аккаунта по правилам банка
            //    account.Interest = account.Balance * 0.4;

            //    if (account.Balance < 1000)
            //        account.Interest -= account.Balance * 0.2;

            // /   if (account.Balance >= 1000)
            //        account.Interest -= account.Balance * 0.4;
            //}
            //else if (account.Type == "Зарплатный")
            //{
                // расчет процентной ставк зарплатного аккаунта по правилам банка
            //    account.Interest = account.Balance * 0.5;
            //}

        }
    }
}

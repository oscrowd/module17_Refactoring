using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module17_Refactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account.Balance = 5000000;
            //account.Interest = 0;
            account.Type = "Зарплатный";
            var calculator = new Calculator();
            calculator.CalculateInterest(new ZPAccountProfile(), account);
            Console.WriteLine("Зарплатный счет: {0}", account.Interest);
            //
            account.Balance = 5000000;
            account.Type = "Обычный";
            calculator.CalculateInterest(new OrdinaryAccountProfile(), account);
            Console.WriteLine("Обычный счет: {0}", account.Interest);
            //
            account.Balance = 5000000;
            account.Type = "Обычный";
            calculator.CalculateInterest(new BigOrdinaryAccountProfile(), account);
            Console.WriteLine("Обычный счет с повышенным процентом: {0}", account.Interest);
            Console.ReadLine();
        }
    }
}

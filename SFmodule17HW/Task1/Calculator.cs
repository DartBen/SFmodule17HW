using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Account;

namespace Task1
{
    internal class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}

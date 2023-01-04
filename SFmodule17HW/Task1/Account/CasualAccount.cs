using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Account
{
    public class CasualAccount :Account, IAccount
    {
        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;
            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}

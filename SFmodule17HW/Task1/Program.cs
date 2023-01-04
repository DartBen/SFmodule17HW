using System.Security.Principal;
using Task1;
using Task1.Account;

internal class Program
{
    private static void Main(string[] args)
    {
        CasualAccount casualAccount1 = new CasualAccount();
        casualAccount1.Type = "Обычный";
        casualAccount1.Balance = 2000.0;
        Calculator.CalculateInterest(casualAccount1);
        Console.WriteLine(casualAccount1.Type +" "+casualAccount1.Interest);

        CasualAccount casualAccount2 = new CasualAccount();
        casualAccount2.Type = "Обычный";
        casualAccount2.Balance = 500.0;
        Calculator.CalculateInterest(casualAccount2);
        Console.WriteLine(casualAccount2.Type + " "+casualAccount2.Interest);

        CasualAccount casualAccount3 = new CasualAccount();
        casualAccount3.Type = "Обычный";
        casualAccount3.Balance = 60000.0;
        Calculator.CalculateInterest(casualAccount3);
        Console.WriteLine(casualAccount3.Type + " "+casualAccount3.Interest);


        SalaryAccount salaryAccount = new SalaryAccount();
        salaryAccount.Type = "Зарплатный";
        salaryAccount.Balance = 2000.0;
        Calculator.CalculateInterest(salaryAccount);
        Console.WriteLine(salaryAccount.Type + " "+salaryAccount.Interest);
    }
}

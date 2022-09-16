using System;

class MoneyWork
{
    public double MoneyIN = 17526 + 218628;
    public double MoneyOUT = 15000 + 15000 + 15000 + 12500 + 12500 + 1873.3 + 1959.025 + 1996.525 + 2677.5 + 2713.2 + (8250 * 5) + (45000 + 45600);
    

    public void AllMoney()
    {
        Console.WriteLine("Total monthly income : {0}", MoneyIN);
        Console.WriteLine("All employee payroll : {0}", MoneyOUT);
        Console.WriteLine("The balance after the income is deducted with all employee payroll expenses. : {0}", MoneyIN - MoneyOUT);
    }
}
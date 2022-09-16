using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Menu to view store information Once selected, information will be displayed.");
        Console.WriteLine("2.The menu displays the co-founder's information. When selected, information will be displayed.");
        Console.WriteLine("3.shop staff information menu When selected, information will be displayed.");
        Console.WriteLine("4.The shop's income and expenses information menu. By referring to the description given earlier. When selecting a menu, information will be displayed.");
        PrintALL();
        
    }

    public static void PrintALL()
    {
        string i = Console.ReadLine();
        if(i == "1"){
        Restur restur = new Restur();
        restur.AllRes();
        }
        else if(i == "2"){
        Founder founder = new Founder();
        founder.AllFouder();
        }
        else if(i == "3"){
        UserWork work = new UserWork();
        work.AllWork();
        }
        else if(i == "4")
        {
        MoneyWork moneywork = new MoneyWork();
        moneywork.AllMoney();
        }
    }

}


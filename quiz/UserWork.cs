using System;

class UserWork
{
    public string[] work = {"store staff", "food delivery man"};
    public string[] nameWork = {"Saidee", "nondee", "Apaidee", "Tomdee"};
    public string[] age = {"20","18","22","25","23"};
    public string[] surnameWork = {"rukdee", "Jaidee","riendee", "ngandee", "rgnndee"};
    public int[] moneywork = {15000, 12500};


    public void AllWork()
    {
        Console.WriteLine("Nameworker");
        Console.WriteLine("Work : {0} Name : {1} Surname : {2} Age : {3} Money : {4}",work[0],nameWork[0],surnameWork[0],age[0],moneywork[0]);
        Console.WriteLine("Work : {0} Name : {1} Surname : {2} Age : {3} Money : {4}",work[0],nameWork[1],surnameWork[1],age[1],moneywork[0]);
        Console.WriteLine("Work : {0} Name : {1} Surname : {2} Age : {3} Money : {4}",work[0],nameWork[2],surnameWork[2],age[2],moneywork[0]);
        Console.WriteLine("Work : {0} Name : {1} Surname : {2} Age : {3} Money : {4}",work[1],nameWork[3],surnameWork[3],age[3],moneywork[1]);
        Console.WriteLine("Work : {0} Name : {1} Surname : {2} Age : {3} Money : {4}",work[1],nameWork[1],surnameWork[4],age[4],moneywork[1]);


    }
}
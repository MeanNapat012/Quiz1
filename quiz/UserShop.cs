public class Founder
{
    public string[] FounderName = {"Tavee","Yuthdee","Jame"};
     public string[] FounderSurname = {"Jaideedee","Tangjairein","RakRongrein"};
    public string[] NumberID = {"153-698-4561237","742-112-5687412","541-772-3215689"};

    public void AllFouder()
    {
        Console.WriteLine("NameFouder");
        Console.WriteLine("Name : {0}  Surname : {1}  NumberID : {2} ", FounderName[0],FounderSurname[0],NumberID[0]);
        Console.WriteLine("Name : {0}  Surname : {1}  NumberID : {2} ", FounderName[1],FounderSurname[1],NumberID[1]);
        Console.WriteLine("Name : {0}  Surname : {1}  NumberID : {2} ", FounderName[2],FounderSurname[2],NumberID[2]);
    }
}
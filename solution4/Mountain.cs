using System;
using System.Security.Cryptography.X509Certificates;
class Mountain : GeographicalObject
    {
    private int peak;
    public int Peak 
    {
        get => peak;
        set
        { if (value < 0) throw new ArgumentException("Вершина гори не може бути від'ємною."); 
            else peak = value; 
        }
    }
    public override string GetInformationSource()
    {
       return "Інформація отримана з геодезичних досліджень";
    }
    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine($"Найвища точка: {peak} m;");
        PrintSource();
    }
}


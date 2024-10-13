using System;
class River : GeographicalObject
{
    private double flowSpeed;
    private double totalLength;
    public double FlowSpeed 
    { get
        { 
            return flowSpeed; 
        }
        set
        {
            if (value < 0) throw new ArgumentException("Швидкість течії не може бути від'ємною.");
            else flowSpeed = value;
        }
    } 

    public double TotalLength 
    {
        get
        {
            return totalLength;
        }
        set
        {
            if (value < 0) throw new ArgumentException("Довжина річки не може бути від'ємною.");
            else totalLength = value;
        }
    } 

    public override string GetInformationSource()
    {
        return "Інформація отримана з метеорологічного центру";
    }
    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine($"Швидкість течії: {FlowSpeed} cm/s;\nДовжина річки: {TotalLength} m;");
        PrintSource();
    }
}

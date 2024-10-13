using System;
class River : IGeographicalObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }
    public string GetInformationSource()
    {
        return "Інформація отримана з метеорологічного центру";
    }
    public void printInfo()
    {
        Console.WriteLine($"Назва об'єкту: {Name};\nКоординати Х і Y: {X}, {Y};\nОпис: {Description};");
        Console.WriteLine($"Швидкість течії: {FlowSpeed} cm/s;\nДовжина річки: {TotalLength} m;");
        Console.WriteLine($"Джерело інформації: {GetInformationSource()};");
        Console.WriteLine("");
    }
}

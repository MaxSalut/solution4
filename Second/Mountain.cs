using System;
using System.Security.Cryptography.X509Certificates;
class Mountain : IGeographicalObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Peak { get; set; }
    public string GetInformationSource()
    {
        return "Інформація отримана з геодоземетричного центру";
    }
    public void printInfo()
    {
        Console.WriteLine($"Назва об'єкту: {Name};\nКоординати Х і Y: {X}, {Y};\nОпис: {Description};");
        Console.WriteLine($"Найвища точка: {Peak} m;");
        Console.WriteLine($"Джерело інформації: {GetInformationSource()};");
        Console.WriteLine("");
    }
}


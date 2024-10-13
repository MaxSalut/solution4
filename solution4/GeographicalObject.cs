using System;
using System.Globalization;
public abstract class GeographicalObject
{
    private double x;
    private double y; 
    private string name; 
    private string description;

    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public virtual string GetInformationSource()
    {
        return "Дані отримані з відкритих джерел. ";
    }
    public virtual void printInfo()
    {
        Console.WriteLine($"Назва об'єкту: {Name};\nКоординати Х і Y: {X}, {Y};\nОпис: {Description};");

    }
    public void PrintSource()
    {
        Console.WriteLine($"Джерело інформації: {GetInformationSource()};");
        Console.WriteLine("");
    }
}
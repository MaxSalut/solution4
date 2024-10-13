class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        
       

    try
        {
            Console.WriteLine("Частина завдання, яка реалізована через абстрактний клас.\n");
            River river1 = new River { X = 51.34137427779651, Y = 30.653608047308698, Name = "Дніпро", Description = "четверта за довжиною і третя за площею басейну річка Європи, річка з найдовшою течією в Україні", FlowSpeed = 100, TotalLength = 2201 };
            Mountain mountain1 = new Mountain { X = 48.160210716448766, Y = 24.500057923291983, Name = "Говерла", Description = "найвища вершина Українських Карпат і найвища точка України. Розташована в гірському масиві Чорногора на межі Надвірнянського району Івано-Франківської області та Рахівського району Закарпатської області, за 17 кілометрів від кордону з Румунією", Peak = 2061 };
            River river2 = new River { X = 51.1328220000277724, Y = 36.747681000028, Name = "Псел", Description = " річка, що протікає в Росії та Україні, — в межах Сумської області і Полтавської області. Ліва притока Дніпра", FlowSpeed = 100, TotalLength = 717};
            Mountain mountain2 = new Mountain { X = 48.04694444447177659, Y = 24.62722222224977742, Name = "Піп Іван", Description = "дна з найвищих вершин Українських Карпат, з висотою 2028.5 м. Розташована на південно-східному кінці головного хребта масиву Чорногора, на межі Івано-Франківської та Закарпатської областей", Peak = 2028 };
            river1.printInfo();
            river2.printInfo();
            mountain1.printInfo();
            mountain2.printInfo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        
    }
}

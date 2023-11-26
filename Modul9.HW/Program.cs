using Modul9.HW;

class Program
{
    static void Main()
    {
        // Создание экземпляра класса Manager
        Manager manager = new Manager("Baurzhan Manager", 35, 50000, 5000);

        // Демонстрация работы методов для класса Manager
        Console.WriteLine("Информация менеджера:");
        manager.GetInfo();
        Console.WriteLine($"Годовая зарплата менеджера: {manager.CalculateAnnualSalary():C}");

        // Создание экземпляра класса Developer
        Developer developer = new Developer("Nursultan Developer", 28, 60000, 100);

        // Демонстрация работы методов для класса Developer
        Console.WriteLine("\nИнформация разработчика:");
        developer.GetInfo();
        Console.WriteLine($"Годовая зарплата  разработчика: {developer.CalculateAnnualSalary():C}");
    }
}

using System;

// Клас Circle згідно із завданням
class Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Запит та введення радіуса з клавіатури
        Console.Write("Введіть радіус кола: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Створення об'єкта кола
        Circle circle = new Circle(radius);

        // Виведення результатів обчислень
        Console.WriteLine($"Площа круга: {circle.GetArea():F2}");
        Console.WriteLine($"Довжина кола: {circle.GetCircumference():F2}");
    }
}

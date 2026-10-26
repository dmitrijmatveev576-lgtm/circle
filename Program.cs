using System;

class Circle
{
    private double radius;

    public double Radius
    {
        get 
        { 
            return radius; 
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Помилка: Радіус повинен бути більше нуля!");
            }
            else
            {
                radius = value;
            }
        }
    }

    public Circle()
    {
        Radius = 1;
    }


    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть радіус кола: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle();
        
        circle.Radius = radius;
        
        Console.WriteLine($"Площа круга: {circle.GetArea():F2}");
        Console.WriteLine($"Довжина кола: {circle.GetCircumference():F2}");
    }
}
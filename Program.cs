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
<<<<<<< HEAD
        Console.Write("Введіть радіус кола: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle();
        
        circle.Radius = radius;
=======
       
        Console.Write("Введіть радіус кола: ");
        double radius = Convert.ToDouble(Console.ReadLine());

      
        Circle circle = new Circle(radius);

>>>>>>> c752b96e9ee657c77b842a20c257f4c6ae939b1d
        
        Console.WriteLine($"Площа круга: {circle.GetArea():F2}");
        Console.WriteLine($"Довжина кола: {circle.GetCircumference():F2}");
    }
}
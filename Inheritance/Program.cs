
Triangle tri = new Triangle(10, 5, 7);
Console.WriteLine(tri.calculateArea());

Circle cir = new Circle(25);
Console.WriteLine(cir.calculateArea());

Rectangle rec = new Rectangle(10.0, 20.5);
Console.WriteLine(rec.calculateArea());
public abstract class Shape
{
    public String name = " ";
    public String color = " ";

    public abstract double calculateArea();

}


class Rectangle : Shape
{
    public double lad1;
    public double lad2;

    public new string name = "Rectangle";
    public new string color = "Gray";

    public override double calculateArea()
    {
        return this.lad1 * this.lad2;
    }

    public Rectangle(double lado1, double lado2)
    {
        this.lad1 = lado1;
        this.lad2 = lado2;
    }
}

class Circle : Shape
{
    public double radius;

    public new string name = "Circle";
    public new string color = "Red";

    public override double calculateArea()
    {
        return Math.PI * radius * radius;
    }

    public Circle(double rad)
    {
        this.radius = rad;
    }
}

class Triangle : Shape
{
    public double lado1;
    public double lado2;
    public double lado3;

    public new String name = "Triangle";
    public new string color = "Yellow";

    public override double calculateArea()
    {
        double semiPerimeter;

        semiPerimeter = (lado1 + lado2 + lado3) / 2.0;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - lado1) * (semiPerimeter - lado2) * (semiPerimeter - lado3));
    }

    public Triangle(double side1, double side2, double side3)
    {
        lado1 = side1;
        lado2 = side2;
        lado3 = side3;
    }

}


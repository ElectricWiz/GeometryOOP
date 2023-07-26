using chatGPT;

namespace chatGPT
{
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
}
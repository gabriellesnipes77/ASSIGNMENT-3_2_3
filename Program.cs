namespace ASSIGNMENT_3_2_3
{


    class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }


        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public static double operator +(Circle c1, Circle c2)
        {
            return c1.Area() + c2.Area();
        }

        public static double operator -(Circle c1, Circle c2)
        {
            return Math.Abs(c1.Area() - c2.Area());
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the radius of the first circle: ");
                double radius1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the radius of the second circle: ");
                double radius2 = Convert.ToDouble(Console.ReadLine());


                Circle circle1 = new Circle(radius1);
                Circle circle2 = new Circle(radius2);

                double sumOfAreas = circle1 + circle2;
                Console.WriteLine($"The sum of the areas of the two circle is: {sumOfAreas}");

                double areaDifference = circle1 - circle2;
                Console.WriteLine($"The difference in the areas of the two circles is {areaDifference}");
            }
        }
    }
}

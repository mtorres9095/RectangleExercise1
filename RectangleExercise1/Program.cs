using System;

namespace RectangleExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            string inputLength;
            string inputWidth;
            double areaOfRectangle;
            // string result;

            Console.WriteLine("Area of a Regtangle:");
            Console.WriteLine("Enter the LENGTH:");
            inputLength = Console.ReadLine();
            length = double.Parse(inputLength);
            Console.WriteLine("Enter the WIDTH:");
            inputWidth = Console.ReadLine();
            width = double.Parse(inputWidth);
            areaOfRectangle = (length*width);
            // result = areaOfRectangle;
            Console.WriteLine("Give a length of "+ inputLength+" inches and width of "+inputWidth+" inches the area is: "+areaOfRectangle+" inches");


        }
    }
}

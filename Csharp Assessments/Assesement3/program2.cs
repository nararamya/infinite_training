using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesement3
{
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;

        }
        public Box Add(Box otherBox)
        {
            double newLength = this.Length + otherBox.Length;
            double newBreadth = this.Breadth + otherBox.Breadth;
            return new Box(newLength, newBreadth);

        }
        public void Display()
        {
            Console.WriteLine($"Box Dimensions:Length={Length},Breadth={Breadth}");
        }
    }
    class program2    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of box 1:");
            int length1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of box 1:");
            int breadth1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of box 2:");
            int length2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of box 2:");
            int breadth2 = int.Parse(Console.ReadLine());

            Box box1 = new Box(length1,breadth1);
            Box box2 = new Box(length2,breadth2);

            Console.WriteLine("Details of Box 1:");
            box1.Display();
            Console.WriteLine("Details of Box 2:");
            box2.Display();

            Box box3 = box1.Add(box2);

            Console.WriteLine("Details of Box 3:");
            box3.Display();
            Console.Read();


        }
    }
}

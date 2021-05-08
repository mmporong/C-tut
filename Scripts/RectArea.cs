using System;

namespace ConsoleApp2
{
    class RectArea
    {
        static void Main(string[] args)
        {

            Console.WriteLine("사각형의 너비?");
            string width = Console.ReadLine();
            int wid = int.Parse(width);

            Console.WriteLine("사각형의 높이?");
            string height = Console.ReadLine();
            int hei = int.Parse(height);

            int area = wid * hei;
            Console.WriteLine("사각형의 넓이는 : " + area);
            

        }
    }
}

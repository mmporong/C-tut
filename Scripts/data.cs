using System;

namespace ConsoleApp1
{
    class Data
    {
        static void Main(string[] args)
        {

            int hp = 100;
            bool IsAlive = (hp > 0);


            while (hp > 50)
            {
                hp--;
                Console.WriteLine(hp);


            }
            bool a = IsAlive;
            Console.WriteLine(a);

        }
    }
}

using System;

namespace Task12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ping Pong";
            Console.Write($"Количество ударов: ");
            int count = Convert.ToInt32(Console.ReadLine());

            PingPong pingPong = new PingPong();
            pingPong.Start(new Ping(), new Pong(), count);

            Console.ReadKey();
        }
    }
}

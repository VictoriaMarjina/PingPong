using System;
namespace PingPong
{
    class Program

    {
        static void Main()
        {
            Ping ping = new Ping();
            Pong pong = new Pong();
            Ping.Ud v = pong.Hit;
            Pong.Ud w = ping.Hit;

            ping.Display += v;
            pong.Display += w;
            ping.Hit();
            
            Console.ReadKey();
        }

        class Pong
        {
            public delegate void Ud();
            public event Ud Display;
            public void Hit()
            {
                Console.WriteLine("Pong received Ping.");
                if (Display != null)
                    Display();
            }
        }

        class Ping
        {
            public delegate void Ud();
            public event Ud Display;
            public void Hit()
            {
                Console.WriteLine("Ping received Pong.");
                if (Display != null)
                    Display();
            }
        }

    }
}


using System;
using System.Threading;

namespace Task12_2
{
    public delegate void PingEvent();
    public delegate void PongEvent();

    class PingPong
    {
        public event PongEvent pongEvent = null;
        public event PingEvent pingEvent = null;

        public void Start(Ping ping, Pong pong, int count)
        {
            Random rnd = new Random();

            pingEvent += ping.DoPing;
            pongEvent += pong.DoPong;

            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 1)
                {
                    Thread.Sleep(rnd.Next(250, 1000));
                    pingEvent?.Invoke();
                }
                else
                {
                    Thread.Sleep(rnd.Next(250, 1000));
                    pongEvent?.Invoke();
                }
            }
        }
    }
}

using System;

namespace Assignment2
{
    public delegate void Handler(); //委托类型

    public class Clock
    {
        public event Handler Tick;//定义类型--委托实例化
        public event Handler Alarm;

        public void Time(string x)
        {
            Console.WriteLine("闹钟设定的时间是：" + x);
            while (true)
            {
                string time = DateTime.Now.ToString();
                Console.WriteLine("当前的时间是" + time);
                if(time==x)
                {
                    Alarm();
                    break;
                }
                Tick();
                System.Threading.Thread.Sleep(1000);
            }
           
        }

    }
    public class A
    {
        public Clock clock = new Clock();
        public A()
        {
            clock.Tick += Clock_Tick;   //clock订阅事件
            clock.Alarm += Clock_Alarm;

        }

        private void Clock_Alarm()
        {
            Console.WriteLine("Alarm事件");
        }

        private void Clock_Tick()
        {
            Console.WriteLine("Tick事件发生了");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("请输入设定的时间：");
            string time = Console.ReadLine();
            A a = new A();
            a.clock.Time(time);

        }
    }
}

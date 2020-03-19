//2、使用事件机制，模拟实现一个闹钟功能。
//闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
//在闹钟走时或者响铃时，在控制台显示提示信息。

using System;
using System.Threading.Tasks;

namespace CSharpHomework4._2
{
    public delegate void ClockHandler(object sender, ClockEventArgs args);

    public class ClockEventArgs:EventArgs
    {
        private DateTime currenttime;
        public DateTime CurrentTime { get => currenttime; set => currenttime = value; }
        private DateTime settime;
        public DateTime SetTime { get => currenttime; set => currenttime = value; }


    }
    public class Clock
    {
        public event ClockHandler Pass;
        public event ClockHandler Alarm;
        
        public void RingClock(DateTime clockalarm)
        {
            ClockEventArgs args = new ClockEventArgs();
            args.CurrentTime = System.DateTime.Now;
            args.SetTime = clockalarm;
            if (DateTime.Compare(args.CurrentTime, args.SetTime) == 0)
            {
                Alarm(this, args);
            }
            else Pass(this, args);


            
        }
        



    }
   


    class Program 
    { 
        static void Main(string[] args)
        {
            var clock = new Clock();
            clock.Pass += showTime;
            clock.Alarm += alarm;
            DateTime set;
            int y, m, d, h, mi, s;
            y = Console.Read();
            m = Console.Read();
            d = Console.Read();
            h = Console.Read();
            mi = Console.Read();
            s = Console.Read();
            set = new DateTime(y, m, d, h, m, s);

            for(int i = 0; i < 60; i++)
            {
                clock.RingClock(set);
                System.Threading.Thread.Sleep(1000);
            }

            static void showTime(object sender,ClockEventArgs args)
            {
                Console.WriteLine("现在的时间是:" + DateTime.Now.ToShortTimeString().ToString());
            }

            static void alarm(object sender,ClockEventArgs args)
            {
                Console.WriteLine("现在是" + DateTime.Now.ToShortTimeString().ToString());
                Console.WriteLine("时间到了");
            }


        }
    }
}
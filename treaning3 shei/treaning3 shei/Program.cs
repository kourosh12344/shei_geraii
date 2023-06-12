
using System;
namespace Project
{
    class test1
    {
        private int t;

        public int T
        {
            get { return t; }
            set { t = value; }
        }
        public test1() { }//تابع مخرب
public test1(int time) {
            T = time;
        }//sazande
        public double show()
        {
            double d = 0.5 * 9.8 * t;
            return d;
        }
        class test2
        {
            public static void Main()
            {
                Console.WriteLine("pls enter Time:");
                int t=Convert.ToInt32(Console.ReadLine());
                test1 ts = new test1(t);
                double g = ts.show();
                Console.WriteLine(g);
            }
        }

    }
}












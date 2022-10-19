using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            bool b = true;
            for(int i = 10; b == true; i = i + n)
            {
                Console.WriteLine(i);
                switch (i)
                {
                    case 30:
                        i = 200;
                        n = -1;
                        break;
                    case 180:
                        i = 1000;
                        n = 50;
                        break;
                    case 1400:
                        b = false;
                        break;


                }
            }
        }
    }
}

using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 0;
            int n2 = 0;
            bool b = true;
            while (b == true)
            {
                Console.WriteLine("Välj ett av förljande alternativ");
                Console.WriteLine("1. Subtrahera ett tal med ett annat.");
                Console.WriteLine("2. Mulitplicera.");
                Console.WriteLine("3. Avlsuta program.");
                int val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        Console.WriteLine("Skriv in de två talen:");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(n1 - n2);
                        break;
                    case 2:
                        Console.WriteLine("Skriv in de två talen:");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(n1 * n2);
                        break;
                    case 3:
                        b = false;
                        Console.WriteLine("Du har avslutat programmet");
                        break;
                    default:
                        Console.WriteLine("Du har valt fel nummer! ");
                        break;

                }


            }
        }
    }
}

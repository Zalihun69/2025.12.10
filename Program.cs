

namespace ConsoleApp18
{


    internal class Program
    {
        static void Main(string[] args)
        {
            UdvozloKep();
            HaromszogSzerkesztheto();
            Terulet();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Kilépés");
            ListazMenu(menupontok);
            Console.WriteLine("Vége!");
        }

        private static void ListazMenu(List<string> menupontok)
        {
            //Petra feladata
            Console.WriteLine("ide jött!");
            Console.WriteLine("ide már jut el!");
        }

        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");


        }
        //TODO : Bihari Balázs  (Kerület számítása)
        private static void Terulet()
        {
            Console.Clear();
            Console.WriteLine("Terület számítása");
            Console.Write("Add meg az alapot: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a magasságot: ");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A háromszög területe: {a * m / 2}");

        }
        //TODO : Bihari Balázs  (Háromszög szerkeszthetősége)
        private static void HaromszogSzerkesztheto()
        {
            Console.Write("Add meg az első oldalt: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a második oldalt: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a harmadik oldalt: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("A háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine("A háromszög NEM szerkeszthető.");
            }
        }
    }
}




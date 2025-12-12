/*Console.Clear();
Console.SetCursorPosition(40, 12);
Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");
Console.SetCursorPosition(50, 13);
Console.WriteLine("[1] kerület számíás");
Console.SetCursorPosition(50, 14);
Console.WriteLine("[2] terület számítás");
Console.SetCursorPosition(50, 15);
Console.WriteLine("[3] kilépés");

int bekeres = Convert.ToInt32(Console.ReadLine());

*/




using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp18
{
    internal class Program
    {
        private static string input;

        static void Main(string[] args)
        {
            UdvozloKep();
        }

        

        private static void UdvozloKep() //(Bura Zalán)
        {
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("[1] kerület számíás");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("[2] terület számítás");
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("[3] megszerkeszthető e a háromszög");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("[4] kilépés");
            Console.SetCursorPosition(50, 17);
            Console.Write("Valassz egyet: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    Kerület();
                    break;
                case "2":
                    Console.Clear();
                    Terulet();
                    break;
                case "3":
                    Console.Clear();
                    HaromszogSzerkesztheto();
                    break;
                case "4":
                    Console.Clear();
                    BeirtKorSugara();
                    break;
                case "5":
                    Console.Clear();
                    Console.SetCursorPosition(45, 14);
                    Console.WriteLine("Kilépés kiválasztva. Viszlát!");
                    break;

            }

            int bekeres = Convert.ToInt32(Console.ReadLine());


        }
        private static void Terulet() //(Bihari Balázs)
        {
            Console.Clear();
            Console.SetCursorPosition(52, 2);
            Console.WriteLine("Terület számítása");
            Console.SetCursorPosition(50, 4);
            Console.Write("Add meg az alapot: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(50, 6);
            Console.Write("Add meg a magasságot: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(50, 8);
            Console.WriteLine($"A háromszög területe: {a * m / 2}");
        }

        private static void HaromszogSzerkesztheto() //(Bihari Balázs)
        {
            Console.SetCursorPosition(53, 2);
            Console.Write("A háromszög adatai!");
            Console.SetCursorPosition(50, 4);
            Console.Write("Add meg az első oldalt: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(50, 6);
            Console.Write("Add meg a második oldalt: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(50, 8);
            Console.Write("Add meg a harmadik oldalt: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("A háromszög szerkeszthető.");
            }
            else
            {
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("A háromszög NEM szerkeszthető.");
            }
        }
        private static void Kerület()
        {
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Kerület számítása:");
            Console.SetCursorPosition(50, 13);
            Console.Write("Add meg az a oldalt: ");
            string a = Console.ReadLine();
            Console.SetCursorPosition(50, 15);
            Console.Write("Add meg a b oldalt: ");

            string b = Console.ReadLine();
            Console.SetCursorPosition(50, 17);
            Console.Write("Add meg a c oldalt: ");

            string c = Console.ReadLine();
            Console.SetCursorPosition(50, 19);
            double Kerület = Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);
            Console.WriteLine($"A háromszög kerülete: {Kerület}");

        }
        private static void BeirtKorSugara()
        {
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Háromszögbe írt kör sugarának kiszámítása:");
            Console.SetCursorPosition(50, 13);
            Console.Write("Add meg az a oldalt: ");
            string a = Console.ReadLine();
            Console.SetCursorPosition(50, 14);
            Console.Write("Add meg a b oldalt: ");
            string b = Console.ReadLine();
            Console.SetCursorPosition(50, 15);
            Console.Write("Add meg a c oldalt: ");
            string c = Console.ReadLine();
            Console.SetCursorPosition(45, 16);
            double s = (Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c)) / 2;
            double terulet = Math.Sqrt(s * (s - Convert.ToDouble(a)) * (s - Convert.ToDouble(b)) * (s - Convert.ToDouble(c)));
            double r = terulet / s;
            Console.WriteLine($"Háromszögbe írt kör sugara: {Math.Round(r, 2)}");

        }
    }
}

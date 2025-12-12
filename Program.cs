namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdvozloKep();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Kilépés");
            ListazMenu(menupontok);
            Console.WriteLine("Vége!");
            Kerület();
            BeirtKorSugara();
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
        
        private static void ListazMenu(List<string> menupontok)
        {
            //Petra feladata
            Console.WriteLine("ide jött!");
            throw new NotImplementedException("Még nincs kész, ezért ne használd!");
            Console.WriteLine("ide már jut el!");
        }

        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");

        
        }
    }
}
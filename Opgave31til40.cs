using System;
using System.Threading;

namespace LearningCsharp
{
    internal class Opgave31til40
    {
        public static void Opgave31()
        {
            //et program der udskriver en gange-tabel
            
            int j = 4;
            Console.Write("Skriv et tal, der er under eller lig med 20: ");
            j = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + " x " + j + " = " + i * j);
            }
            Console.ReadLine();

        }

        public static void Opgave32()
        {
            //exit ved 50
            int tal;
            Console.Write("Indtast et tal: ");
            tal = Int32.Parse(Console.ReadLine());
            while (tal != 50)
            {
                Console.WriteLine("Udfør program.");
                Console.Write("Indtast et tal: ");
                tal = Int32.Parse(Console.ReadLine());
            }
        }
        public static void Opgave33()
        {
            /* Programmet slår med en terning 100 gange.
             * Objektet Random.Next(int, int) udskriver et tilfældigt tal med start ved 1 og under 7
             Man kan også bare skrive et tal, der så bliver et positivt tal under det tal, man anfører.
            Men da en terning ikke kan vise nul, så giver det bedre mening med start ved 1*/

            Random RandomObj = new Random();
            int øjne, antal, i;
            i = 0;
            do
            {
                øjne = RandomObj.Next(1, 7);
                Console.WriteLine("Terning viste: {0}", øjne);
                antal = i;
                i++;
                Console.WriteLine(antal);
            }
            while (antal < 100);
            Console.ReadKey();
        }
        public static void Opgave34()
        {
            //Et program som tæller antal 1-ere, 2-ere osv. når man kaster terningen 1000 gange

            Random tilfældigtTal = new Random();
            int øjne;
            int a = 0; int b = 0; int c = 0; int d = 0; int e = 0; int f = 0; //tæller terningens forskellige øjne    
            int i = 0; //tæller antal gange

            while (i < 1000)
            {
                i++;
                øjne = tilfældigtTal.Next(1, 7);
                Console.WriteLine("Terning viste: {0}", øjne);
                if (øjne == 1)
                {
                    a++;
                }
                else if (øjne == 2)
                {
                    b++;
                }
                else if (øjne == 3)
                {
                    c++;
                }
                else if (øjne == 4)
                {
                    d++;
                }
                else if (øjne == 5)
                {
                    e++;
                }
                else if (øjne == 6)
                {
                    f++;
                }

                //a + b + c + d + e + f;
            }
            Console.WriteLine("Antal gange, der var:");
            Console.WriteLine("Ettere: " + a);
            Console.WriteLine("Toere: " + b);
            Console.WriteLine("Treere: " + c);
            Console.WriteLine("Firere: " + d);
            Console.WriteLine("Femmere: " + e);
            Console.WriteLine("Seksere: " + f);
            Console.ReadKey();

        }
        public static void Opgave35()
        {
            //I dette program skal man gætte et navn på en by på Fyn.
            //Der er en tæller så man kan se hvor mange gæt man har brugt.

            string svar = "";
            int a = 0;
            Random randomNr = new Random();
            int tilfældigtNr = randomNr.Next(13);
            string[] fynskeByer = {"Odense", "Kerteminde", "Munkebo", "Rynkeby", "Dalby", "Bogense", "Otterup", "Middelfart", "Faaborg", "Assens", "Svendborg", "Nyborg", "Ringe"};
            string tilfældigBy = fynskeByer[tilfældigtNr].ToLower();
            Console.WriteLine("Du skal gætte en tilfældig by på Fyn. Programmet slutter først, " +
                  "når du har gættet rigtigt eller taster (q).");
            while (svar != tilfældigBy && svar != "q")
            {
                Console.Write("Skriv dit svar her: ");
                svar = Console.ReadLine().ToLower();
                a++;
                if (svar == tilfældigBy)
                {
                    Console.WriteLine($"Tillykke!!! Du gættede rigtigt på gæt nr: {a}.");
                }
                else { Console.WriteLine($"Antal forsøg: {a}"); }
            }
        }
        public static void Opgave36()
        {
            //Vælg en t-shirt størrelse og antal, try - catch
            string size;
            Int32 antal = 0;
            Int32 pris = 0;

            Console.WriteLine("Velkommen i US T-shirts. Vi har t-shirts i tre forskellige størrelser.");
            Console.WriteLine("Vi har størrelse (S)MALL til 120 kroner, (M)EDIUM til 160 kroner og (L)arge til 185 kroner. ");


            do
            {
                Console.WriteLine("Hvilken størrelse ønsker du?: ");
                size = Console.ReadLine().ToLower();
                if (size == "s")
                {
                    pris = 120;
                }
                if (size == "m")
                {
                    pris = 160;
                }
                if (size == "l")
                {
                    pris = 185;
                }

                if (size != "s" && size != "m" && size != "l")
                {
                    Console.Write("Du har ikke indtastet en størrelse, vi har. Vi har kun S/M/L. Indtast en størrelse: ");
                }

            } while (size != "s" && size != "m" && size != "l");

            try
            {
                Console.Write("Hvor mange ønsker du?: ");
                antal = Convert.ToInt32(Console.ReadLine());

                double sum = antal * pris; //sum uden rabat
                double rabat = sum * 0.05; //rabat ved køb over 10
                double sumMedRabat = sum - rabat; //sum med rabat

                if (antal > 10)
                {
                    Console.WriteLine($"Din pris uden rabat er: {sum:C}");
                    Console.WriteLine($"Du får {rabat:C} i rabat, fordi du har købt flere end 10");
                    Console.WriteLine($"Din pris er derfor {sumMedRabat:C}");
                    Console.ReadLine();
                }
                else if (antal > 0 && antal <= 10)
                {
                    Console.WriteLine($"Din pris er: {sum:C}");
                    Console.ReadLine();
                }
                else if (antal == 0)
                {
                    return;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Du har ikke tastet et antal. Ordren annulleres. Kom igen en anden gang.");
            }

        }
        public static void Opgave37()
        {

            string userPW = "";
            int i = 0;
            string PW = "Ab123456";
            Console.Write("Indtast adgangskode for at komme ind i systemet: ");
            while (PW != userPW && i != 5)
            {
                userPW = Console.ReadLine();

                if (userPW == PW)
                {
                    Console.Write("Korrekt! Du har nu adgang til systemet.");
                }
                else
                {
                    i++;
                    Console.WriteLine($"Du har indtastet forkert adgangskode. Du har {5-i} forsøg tilbage.");             
                }

            }
            Console.Write("Du logges ud af systemet.");
            for (int j = 0; j < 20; j++)
            {
                Thread.Sleep(200);
                Console.Write(".");
            }
        }
        public static void Opgave38()
        {
            //switch-case
            Console.WriteLine("|||  [Tast 1] |||");
            Console.WriteLine("|||  [Tast 2] |||");
            Console.WriteLine("|||  [Tast 3] |||");

            Console.Write("Indtast dit valg: ");
            string valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    {
                        Console.WriteLine("Du valgte nummer 1.");
                        break;

                    }
                case "2":
                    {
                        Console.WriteLine("Du valgte nummer 2.");
                        break;
                    }

                case "3":
                    {
                        Console.WriteLine("Du valgte nummer 3.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Du har ikke valgt noget.");
                        break;
                    }
            }
        }
    }
}

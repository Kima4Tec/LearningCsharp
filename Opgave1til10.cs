using System;
using System.Net.NetworkInformation;
using MitEgetNS;

namespace LearningCsharp
{
    public class Opgave1til10
    {
        public static void Opgave1()
        {
            //Brug Console.Write til at udskrive nogle data, fx fornavn, efternavn og by


            //Console.Write("Svend ");
            //Console.Write("Nielsen, \n");
            //Console.Write("Holbæk");
            //Console.ReadLine();

            //Prøv at skrive det samme med Console.WriteLine

            Console.WriteLine("Svend ");
            Console.WriteLine("Nielsen");
            Console.WriteLine("Holgervej 7");

            Console.WriteLine();
        }

        public static void Opgave2()
        {
            //Man kan skrive en kommentar på en enkelt linje.

            /*
             * Eller med flere linjer som et
             * helt afsnit. Det er en god idé at
             * forklare, hvad du gør, fx: "Jeg udskriver en tekst"
             */
            Console.WriteLine("Udskrevet tekst.");
        }

        public static void Opgave3()
        {
            //Der er forskel på store og små bogstaver i c#
            //Semikolon afslutter en instruktion
            double a = 2.2;
            int A = 9;
            Console.WriteLine(a + A);
        }
        public static void Opgave4()
        {
            //Variabler og input
            //Først opretter jeg en variabel af typen "string"
            string navn = "Svend";

            //Jeg udskriver variablen
            Console.WriteLine("Mit navn er: " + navn);

            //Jeg spørger til brugers navn:
            Console.Write("Hvad er dit navn?: ");

            //Jeg sætter brugers indtastning i en variabel
            string brugerNavn = Console.ReadLine();

            //Jeg udskriver brugers indtastning.
            Console.WriteLine("Dit navn er altså: " + brugerNavn);

            //man kan også indfange brugers indtastning af kun et tegn
            //først info
            Console.WriteLine("Tryk på ENTER");

            //dernæst erklæring af variablen k af typen ConsoleKeyInfo, som er lig med brugers indtastning af et tegn
            ConsoleKeyInfo k = Console.ReadKey();
            
            //med en if-betingelse undersøger jeg brugers indtastning. Hvis tegnet er lig med ENTER, så frembring lyd og udskriv tekst
            if (k.Key == ConsoleKey.Enter)
                {
                Console.Beep();
                Console.WriteLine("Du trykkede på [ENTER]"); 
                }
            //Her brugte jeg forskellige prædefinerede typer: class, struct, enum og egenskaben Key (ConsoleKeyInfo.Key Property)
        }
        public static void Opgave5()
        {
            //Placér en tekst et sted på skærmen.


            //Console.SetCursorPosition(5, 5);
            //string text = "tekst";
            //Console.WriteLine(text);
            //Tools.VisXOgY();
            //Console.ReadLine();
            //Console.Clear();


            //int centerText = text.Length / 2;
            //Console.SetCursorPosition(5-centerText, 5);
            //Console.WriteLine(text);
            //Tools.VisXOgY();
            //Console.ReadLine();


            //placer teksten på midten
            //min konsolskærm er 120 * 30.Kan ses i settings på konsolskærm.

            //int antalX = 120;
            //int antalY = 30;
            //int centrumX = 120 / 2;
            //int centrumY = 30 / 2;
            //string txt = "tekst";
            //int centrumTekst = txt.Length / 2;

            //Console.SetCursorPosition(centrumX - centrumTekst, centrumY);
            //Console.WriteLine(txt);



            int windowBredde = Console.WindowWidth;
            int windowHøjde = Console.WindowHeight;
            int CenterX = windowBredde / 2;
            int CenterY = windowHøjde / 2;

            string linje = "Dette er centreret i midten af konsolvinduet.";
            Console.SetCursorPosition(CenterX - (linje.Length / 2), CenterY);
            Console.WriteLine(linje);
            Console.ReadLine();

        }
        public static void Opgave6()
        {
            //Konvertering og udskrivning af specielle tegn, fx copyright

            //I C# skal du kigge på Latin-1 Supplement for at finde copyright-tegnet.
            // © er 00A9(hexadecimalt)
            //Du finder det her: https://unicode.org/charts/

            //For konverterer jeg hexadecimaltallet om til et decimaltal, og dernæst kan jeg udskrive
            //det specielle tegn ved at bruge (char)decimaltallet
            string hexTal = "00A9";
            int hexTilDecTal = Convert.ToInt32(hexTal, 16); //output: 169
            char specTegn = (char)hexTilDecTal;
            Console.WriteLine("Her er det specielle tegn: " + specTegn);

        }

        public static void Opgave7()
        {
            //Skriv en tekst med argumenter

            //Console.WriteLine("Her er det specielle tegn igen: {0}. Her er et andet specielt tegn {1}.", (char)169, (char)178 );

            //Console.WriteLine("Jeg hedder {0} og jeg er {1} år gammel", "Svend", 45);

            string navn = "Niels";
            int saldo = 5000;
            Console.WriteLine($"Jeg hedder {navn} og har {saldo:C} i banken");
        }

        public static void Opgave8()
        {
            //baggrundsfarve og forgrundsfarve
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Svend ");
            Console.WriteLine("Nielsen");
            Console.WriteLine("Holgervej 7");
            Console.ReadLine(); //venter på enter
            Console.ResetColor();// tilbage til defaultfarverne
        }

        public static void Opgave9()
        {
            //Lav et flag

            ////to rækker rød/hvid/rød
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.Write("           ");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Write("    ");
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("                       ");

            //Console.Write("           ");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Write("    ");
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("                       ");

            //////En række hvid
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.WriteLine("                                      ");
            //Console.WriteLine("                                      ");

            //////To rækker rød/hvid/rød
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.Write("           ");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Write("    ");
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("                       ");
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.Write("           ");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Write("    ");
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("                       ");

            //Console.ResetColor();

            Console.Title = "Dansk flag";
            for (int i = 0; i < 14; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(10, 0 + i);
                Console.WriteLine("                                      ");
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(10, 6);
            Console.WriteLine("                                      ");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("                                      ");

            for (int i = 0; i < 14; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.SetCursorPosition(22, 0 + i);
                Console.WriteLine("    ");
            }
            Console.ResetColor();
        }
        public static void Opgave10()
        {
            //Her har jeg udvidet programmet på en simpel måde, så man selv kan vælge hvilket flag, man vil have.
            //Jeg har tilført lidt nyt. Det kan skrives bedre, men jeg har forsøgt ikke at gøre det for svært.
            //Jeg bruger en if-betingelse, for at undersøge, hvad bruger taster som input
            //Jeg spørger først til flagfarve og korsfarve
            //Farverne bliver sat ind i variabler
            //Jeg starter med at gøre baggrunden grå. I denne opgave kunne man godt have lagt noget i metoder
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.SetCursorPosition(1, 0);

            string OutTekst = "Vælg en {0} for et flag: (h) for hvid, " +
                "(g) for gul, (r) for rød, og (b) for blå: ";

            Console.Write(OutTekst, "baggrundsfarve");

            ConsoleColor flagFarve = ConsoleColor.DarkRed;
            //Tryk en tast og gå videre. Tastevalget bliver både brugt til
            //at definere flaget og udskrive farve på skærmen.
            ConsoleKeyInfo EnTast = Console.ReadKey(true);
            string valgtFarve = EnTast.KeyChar.ToString().ToLower();

            Console.WriteLine(valgtFarve);
            if (valgtFarve == "h")
            {
                flagFarve = ConsoleColor.White;
                Console.SetCursorPosition(OutTekst.Length, 0);
                Console.WriteLine("    ");
            }
            else if (valgtFarve == "g")
            {
                flagFarve = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(OutTekst.Length, 0);
                Console.WriteLine("    ");
            }
            else if (valgtFarve == "r")
            {
                flagFarve = ConsoleColor.DarkRed;
                Console.SetCursorPosition(OutTekst.Length, 0);
                Console.WriteLine("    ");
            }
            else if (valgtFarve == "b")
            {
                flagFarve = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.SetCursorPosition(10, 22);
                Console.WriteLine("Du har tastet noget andet, end valgmulighederne. " +
                    "Flagfarve sættes til magenta.");
                flagFarve = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(OutTekst.Length, 0);
                Console.WriteLine("Magenta");
            }

            for (int i = 0; i < 14; i++)
            {
                Console.BackgroundColor = flagFarve;
                Console.SetCursorPosition(10, 3 + i);
                Console.WriteLine("                                      ");
            }

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 0);
            Console.Write("                                                                                                                   ");
            Console.SetCursorPosition(0, 1);
            Console.Write(OutTekst, "korsfarve");
            ConsoleColor korsFarve = ConsoleColor.DarkRed;
            ConsoleKeyInfo EnNyTast = Console.ReadKey(true);
            string valgtKorsFarve = EnNyTast.KeyChar.ToString().ToLower();
            if (valgtKorsFarve == "h")
            {
                korsFarve = ConsoleColor.White;
            }
            else if (valgtKorsFarve == "g")
            {
                korsFarve = ConsoleColor.DarkYellow;
            }
            else if (valgtKorsFarve == "r")
            {
                korsFarve = ConsoleColor.DarkRed;
            }
            else if (valgtKorsFarve == "b")
            {
                korsFarve = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.SetCursorPosition(10, 22);
                Console.WriteLine("Du har tastet noget andet, end valgmulighederne. " +
                    "Flagkors sættes til grøn.");
                korsFarve = ConsoleColor.DarkGreen;
            }

            Console.BackgroundColor = korsFarve;
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("                                      ");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("                                      ");

            for (int i = 0; i < 14; i++)
            {
                Console.BackgroundColor = korsFarve;
                Console.SetCursorPosition(22, 3 + i);
                Console.WriteLine("    ");
            }
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(10, 18);
            if (valgtFarve == "r" && valgtKorsFarve == "h")
            {
                Console.WriteLine("Danmark");
            }
            else if (valgtFarve == "b" && valgtKorsFarve == "g")
            {
                Console.WriteLine("Sverige");
            }
            else if (valgtFarve == "h" && valgtKorsFarve == "b")
            {
                Console.WriteLine("Finland");
            }
            else if (valgtFarve == "h" && valgtKorsFarve == "r")
            {
                Console.WriteLine("England");
            }
            else if (valgtFarve == "r" && korsFarve == ConsoleColor.DarkGreen)
            {
                Console.WriteLine("Uofficielt for Bornholm");
            }
            else if (valgtFarve == "g" && valgtKorsFarve == "h")
            {
                Console.WriteLine("Stockholms katolske domkirkes flag");
            }
            else if (valgtFarve == "g" && valgtKorsFarve == "b")
            {
                Console.WriteLine("Uofficielt flag for Östergötland");
            }
            else if (valgtFarve == "b" && valgtKorsFarve == "h")
            {
                Console.WriteLine("Skotland");
            }

            Console.SetCursorPosition(10, 19);
            Console.ReadLine();
        }
    }
}

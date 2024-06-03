using System;
using System.Threading;

namespace LearningCsharp
{
    internal class Opgave41til50
    {
        public static void Opgave41()
        {
            //Her har jeg lagt en while løkke udenom min switch-case. Det betyder, at man først kommer
            //ud af programmet, når man trykker 9. Der er også en default, der træder i kraft, hvis man trykker
            //noget andet.

            string valg = "";

                Console.WriteLine("------------------------------------");
                Console.WriteLine("|||           * Menu *           |||");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("||| - Hvilken kaffe ønsker du? - |||");
                Console.WriteLine("||| ---------------------------- |||");
                Console.WriteLine("||| For sort kaffe:     [Tast 1] |||");
                Console.WriteLine("||| For kaffe med mælk: [Tast 2] |||");
                Console.WriteLine("||| For mælk:           [Tast 3] |||");
                Console.WriteLine("||| For afslut:         [Tast 9] |||");
                Console.WriteLine("------------------------------------");

            while (valg != "1" && valg != "2" && valg != "3" && valg != "9")
            {
                Console.Write("Indtast dit valg her: ");
                valg = Console.ReadLine();
                switch (valg)
                {
                    case "1":
                        {
                            Console.WriteLine("Du valgte nummer 1. Du får kaffe.");
                            break;

                        }
                    case "2":
                        {
                            Console.WriteLine("Du valgte nummer 2. Du får kaffe med mælk.");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Du valgte nummer 3. Du får mælk.");
                            break;
                        }

                    case "9":
                        Console.WriteLine("Du valgte at afslutte.");
                        break;

                    default:
                        {
                            Console.WriteLine($"Valg nr. {valg} indgår ikke i menuen. Tast 9 for at afslutte.");
                            break;
                        }
                }
            }
        }
        public static void Opgave42()
        {
            //Et program, hvor man kan vælge drinks og får vist prisen

            string valg = "";
            double pris = 0;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("|||          * Priser *          |||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("|||    -  Priser for drinks  -   |||");
            Console.WriteLine("||| ---------------------------- |||");
            Console.WriteLine("||| For Daiquiri        [Tast 1] |||");
            Console.WriteLine("||| For Margarita       [Tast 2] |||");
            Console.WriteLine("||| For White Russian   [Tast 3] |||");
            Console.WriteLine("||| For Metropolitan    [Tast 4] |||");
            Console.WriteLine("||| For Manhattan       [Tast 5] |||");
            Console.WriteLine("||| For afslut:         [Tast 9] |||");
            Console.WriteLine("------------------------------------");

            while (valg != "1" && valg != "2" && valg != "3" && valg != "4" && valg != "5" && valg != "9")
            {
                Console.Write("Indtast dit valg her: ");
                valg = Console.ReadLine();
                switch (valg)
                {
                    case "1":
                        {
                            pris = 71;
                            Console.WriteLine($"Du valgte Daiquiri. Den koster {pris:C}.");
                            break;

                        }
                    case "2":
                        {
                            pris = 115;
                            Console.WriteLine($"Du valgte Margarita. Den koster {pris:C}.");
                            break;
                        }
                    case "3":
                        {
                            pris = 73;
                            Console.WriteLine($"Du valgte White Russian. Den koster {pris:C}.");
                            break;
                        }
                    case "4":
                        {
                            pris = 91;
                            Console.WriteLine($"Du valgte Metropolitan. Den koster {pris:C}.");
                            break;
                        }
                    case "5":
                        {
                            pris = 91;
                            Console.WriteLine($"Du valgte Manhattan . Den koster {pris:C}.");
                            break;
                        }

                    case "9":
                        {
                            Console.WriteLine("Du valgte at afslutte.");
                            Thread.Sleep(1000);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine($"Valg nr. {valg} indgår ikke i menuen. Tast 9 for at afslutte.");
                            break;
                        }
                        
                }

            }
        }
        public static void Opgave43()
        {
            //I dette program omskriver jeg Switch case strukturen til en if-betingelse.
            //Sådan at man ikke kan se forskel når programmet kører.
            string valg = "";
            double pris = 0;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("|||          * Priser *          |||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("|||    -  Priser for drinks  -   |||");
            Console.WriteLine("||| ---------------------------- |||");
            Console.WriteLine("||| For Daiquiri        [Tast 1] |||");
            Console.WriteLine("||| For Margarita       [Tast 2] |||");
            Console.WriteLine("||| For White Russian   [Tast 3] |||");
            Console.WriteLine("||| For Metropolitan    [Tast 4] |||");
            Console.WriteLine("||| For Manhattan       [Tast 5] |||");
            Console.WriteLine("||| For afslut:         [Tast 9] |||");
            Console.WriteLine("------------------------------------");

            while (valg != "1" && valg != "2" && valg != "3" && valg != "4" && valg != "5" && valg != "9")
            {
                Console.Write("Indtast dit valg her: ");
                valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        pris = 71;
                        Console.WriteLine($"Du valgte Daiquiri. Den koster {pris:C}.");
                        break;
                    case "2":
                        pris = 115;
                        Console.WriteLine($"Du valgte Margarita. Den koster {pris:C}.");
                        break;
                    case "3":
                        pris = 73;
                        Console.WriteLine($"Du valgte White Russian. Den koster {pris:C}.");
                        break;
                    case "4":
                        pris = 91;
                        Console.WriteLine($"Du valgte Metropolitan. Den koster {pris:C}.");
                        break;
                    case "5":
                        pris = 91;
                        Console.WriteLine($"Du valgte Manhattan . Den koster {pris:C}.");
                        break;
                    case "9":
                        Console.WriteLine("Du valgte at afslutte.");
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine($"Valg nr. {valg} indgår ikke i menuen. Tast 9 for at afslutte.");
                        break;
                }
            }
        }
        public static void Opgave44()
        {
            string valg = "";

            Console.WriteLine("------------------------------------");
            Console.WriteLine("|||        * Udregning *         |||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("|||  - Vil du udregn arealet -   |||");
            Console.WriteLine("||| ---------------------------- |||");
            Console.WriteLine("||| af en trekant       [Tast 1] |||");
            Console.WriteLine("||| af et rektangel     [Tast 2] |||");
            Console.WriteLine("||| af en cirkel        [Tast 3] |||");
            Console.WriteLine("||| For afslut:         [Tast 9] |||");
            Console.WriteLine("------------------------------------");

            while (valg != "1" && valg != "2" && valg != "3" && valg != "9")
            {
                Console.Write("Indtast dit valg her: ");
                valg = Console.ReadLine();
                switch (valg)
                {
                    case "1":
                        {
                            Console.WriteLine("Her kan du finde arealet af en trekant.");
                            Console.Write("Indtast højde på trekant, som du vil kende arealet på, i cm: ");
                            string svar1 = Console.ReadLine(); //prompt
                            double hojde = Convert.ToDouble(svar1);//variabel
                            Console.Write("Indtast grundlinjens længde på trekanten i cm: ");
                            string svar2 = Console.ReadLine();//Prompt
                            double grundlinje = Convert.ToDouble(svar2);//variable
                            double arealTrek = 0.5 * hojde * grundlinje;//udregning i en ny variabel
                            Console.WriteLine($"Arealet af trekanten er {arealTrek:N2} cm²");//udskriv udregning
                            break;

                        }
                    case "2":
                        {;
                            Console.Write("Indtast højde på det rektangel i cm, som du vil udregne: ");
                            string svar3 = Console.ReadLine(); //prompt
                            double laengde = Convert.ToDouble(svar3);//variabel
                            Console.Write("Indtast firkantens bredde i cm: ");
                            string svar4 = Console.ReadLine();//Prompt
                            double bredde = Convert.ToDouble(svar4);//variable
                            double arealRekt = laengde * bredde;//udregning i en ny variabel
                            Console.WriteLine($"Arealet af firkanten er {arealRekt:N2} cm².");//udskriv udregning
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Indtast radius på den cirkel, som du vil udregne: ");
                            string svar6 = Console.ReadLine(); //prompt
                            double radius = Convert.ToDouble(svar6);//variabel
                            double pi = Math.PI;
                            double exp = Math.Pow(radius, 2);
                            double arealC = pi * exp;//udregning i en ny variabel
                            Console.WriteLine($"Arealet på cirklen er {arealC:N2} cm²");
                            break;
                        }

                    case "9":
                        {
                            Console.WriteLine("Du valgte at afslutte.");
                            Thread.Sleep(1000);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine($"Valg nr. {valg} indgår ikke i menuen. Tast 9 for at afslutte.");
                            break;
                        }

                }
                Console.ReadKey();

            }

        }
        public static void SetColor(ConsoleColor forFarve, ConsoleColor bagFarve)
        {
            Console.ForegroundColor = forFarve;
            Console.BackgroundColor = bagFarve;
        }
        public static void Opgave45()
        {
            string valg;

            Console.WriteLine();

            valg = "";
            double pris = 0;

            while (valg != "9") //while looper indtil 9 bliver tastet
            {
                Console.Clear(); //jeg clearer før menuen for det er pænest, når den kaldes igen
                SetColor(ConsoleColor.Black, ConsoleColor.Gray);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("|||      * Cirkus Baldian *      |||");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("|||       -  Pladspriser  -       |||");
                Console.WriteLine("||| ----------------------------- |||");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("||| For Blå pladser      [Tast 1] |||");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("||| For Røde pladser     [Tast 2] |||");
                SetColor(ConsoleColor.Black, ConsoleColor.Yellow);
                Console.WriteLine("||| For Gule pladser     [Tast 3] |||");
                SetColor(ConsoleColor.Black, ConsoleColor.Magenta);
                Console.WriteLine("||| For lyserøde pladser [Tast 4] |||");
                SetColor(ConsoleColor.Black, ConsoleColor.Gray);
                Console.WriteLine("|||                               |||");
                Console.WriteLine("||| For afslut:          [Tast 9] |||");
                Console.WriteLine("-------------------------------------");
                Console.ResetColor();
                Console.Write("Indtast valg: ");
                valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        {
                            pris = 190;
                            Console.Clear();
                            Console.WriteLine("Blå pladser er parket og terrasse. Vores allerbilligste pladser.");
                            Console.WriteLine($"Blå pladser koster {pris:C}");
                            break;

                        }
                    case "2":
                        {
                            pris = 250;
                            Console.Clear();
                            Console.WriteLine("Røde pladser er vores mest populære pladser.");
                            Console.WriteLine($"Røde pladser koster {pris:C}");
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("De gule pladser er centrale pladser med godt udsyn. Her får I virkelig værdi for pengene.");
                            Console.WriteLine($"Gule pladser koster {pris:C}");
                            break;
                        }
                    case "4":
                        {
                            pris = 320;
                            Console.Clear();
                            Console.WriteLine("De lyserøde pladser er vores mest ekslusive pladser helt tæt på scenen.");
                            Console.WriteLine($"Lyserøde pladser koster {pris:C}");
                            break;
                        }

                    case "9":
                        Console.WriteLine("Du valgte at afslutte.");
                        break;

                    default:
                        {
                            Console.WriteLine("Du skal taste 9 for at afslutte.");
                            break;
                        }
                }
                Console.WriteLine("Tryk [Enter].");
                Console.ReadKey();
            }
        }
        public static void EnkeltTypePris(string type, int pris)
        {
            Console.WriteLine("Billetterne: " + type + " koster " + pris + " kroner.");
        }
        public static void TiTurTypePris(string type, int pris)
        {
            Console.WriteLine("10-turskort til " + type + " koster " + pris + " kroner.");
        }
        public static void Opgave46()
        {
            Console.WriteLine();

            string valg = "";

            while (valg != "9") //while looper indtil 9 bliver tastet
            {
                Console.Clear(); //jeg clearer før menuen for det er pænest, når den kaldes igen
                Console.WriteLine(" ------------------------------------------------------------------------------------- ");
                Console.WriteLine("|                             |   Trommesø Svømmehal   |                              |");
                Console.WriteLine("|                              ----------------------                                 |");
                Console.WriteLine("|                             |    Køb af billetter    |                              |");
                Console.WriteLine(" ------------------------------------------------------------------------------------- ");
                Console.WriteLine("|[Tast 1] Voksne 42 kr                                                                |");
                Console.WriteLine("|[Tast 2] Pensionister, Efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse,|");
                Console.WriteLine("|         dagpengemodtager og studerende (dokumentation påkrævet) 23 kr               |");
                Console.WriteLine("|[Tast 3] Børn (under 7 år i følgeskab med en voksen.) Gratis                         |");
                Console.WriteLine("|[Tast 4] Børn (7-15 år)                                                              |");
                Console.WriteLine("|[Tast 5] Skoleferiebillet Børn (7-15 år) sommer/efterår/vinter 10 kr                 |");
                Console.WriteLine("|[Tast 6] Voksne 330 kr                                                               |");
                Console.WriteLine("|[Tast 7] Pensionister, Efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse,|");
                Console.WriteLine("|         dagpengemodtager og studerende (dokumentation påkrævet) 175 kr              |");
                Console.WriteLine("|[Tast 8] Børn (7-15 år) 135 kr                                                       |");
                Console.WriteLine("|[Tast 9] For afslut:                                                                 |");
                Console.WriteLine(" ------------------------------------------------------------------------------------- ");
                valg = Console.ReadLine();
                try
                {
                    switch (valg) // 
                    {
                        case "1":
                            {
                                Console.Clear();
                                EnkeltTypePris("Voksne", 42);
                                Console.WriteLine("Vil du købe denne billet? (j/n): ");
                                string BuySelect = Console.ReadLine();
                                if (BuySelect == "j")
                                {
                                    int pris = 42;
                                    Console.WriteLine("Hvor mange vil du have?");
                                    int antal = Convert.ToInt16(Console.ReadLine());
                                    int sum = pris * antal;
                                    Console.WriteLine($"Prisen for billetterne er: {sum:C}.");
                                }
                                break;

                            }
                        case "2":
                            {
                                Console.Clear();
                                EnkeltTypePris("Speciel rabat billetter", 23);
                                {
                                    int pris = 23;
                                    Console.WriteLine("Hvor mange vil du have?");
                                    int antal = Convert.ToInt16(Console.ReadLine());
                                    int sum = pris * antal;
                                    Console.WriteLine($"Prisen for billetterne er: {sum:C}.");
                                }
                                break;
                            }
                        case "3":
                            {
                                Console.Clear();
                                EnkeltTypePris("Børn (under 7 år)", 0);
                                {
                                    int pris = 0;
                                    Console.WriteLine("Hvor mange vil du have?");
                                    int antal = Convert.ToInt16(Console.ReadLine());
                                    int sum = pris * antal;
                                    Console.WriteLine($"Prisen for billetterne er: {sum:C}.");
                                }
                                break;
                            }
                        case "4":
                            {
                                Console.Clear();
                                EnkeltTypePris("Børn (7-15 år)", 15);
                                {
                                    int pris = 15;
                                    Console.WriteLine("Hvor mange vil du have?");
                                    int antal = Convert.ToInt16(Console.ReadLine());
                                    int sum = pris * antal;
                                    Console.WriteLine($"Prisen for billetterne er: {sum:C}.");
                                }
                                break;
                            }
                        case "5":
                            {
                                Console.Clear();
                                EnkeltTypePris("Skoleferiebillet Børn (7-15 år)", 10);
                                {
                                    int pris = 10;
                                    Console.WriteLine("Hvor mange vil du have?");
                                    int antal = Convert.ToInt16(Console.ReadLine());
                                    int sum = pris * antal;
                                    Console.WriteLine($"Prisen for billetterne er: {sum:C}.");
                                }
                                break;
                            }
                        case "6":
                            {
                                Console.Clear();
                                TiTurTypePris("Voksne", 330);
                                {
                                    int pris = 330;
                                    Console.WriteLine("Hvor mange vil du have?");
                                    int antal = Convert.ToInt16(Console.ReadLine());
                                    int sum = pris * antal;
                                    Console.WriteLine($"Prisen for billetterne er: {sum:C}.");
                                }
                                break;
                            }
                        case "7":
                            {
                                Console.Clear();
                                TiTurTypePris("Speciel rabat", 175);
                                {
                                    int pris = 175;
                                    Console.WriteLine("Hvor mange vil du have?");
                                    int antal = Convert.ToInt16(Console.ReadLine());
                                    int sum = pris * antal;
                                    Console.WriteLine($"Prisen for billetterne er: {sum:C}.");
                                }
                                break;
                            }
                        case "8":
                            Console.Clear();
                            TiTurTypePris("Børn (7-15 år)", 135);
                            {
                                int pris = 135;
                                Console.WriteLine("Hvor mange vil du have?");
                                int antal = Convert.ToInt16(Console.ReadLine());
                                int sum = pris * antal;
                                Console.WriteLine($"Prisen for billetterne er: {sum:C}.");
                            }
                            break;
                        case "9":
                            Console.WriteLine("Du valgte at afslutte.");
                            break;

                        default:
                            {
                                Console.WriteLine("Du skal taste 9 for at afslutte.");
                                break;
                            }
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Din indtastning er ugyldig.");
                }
                Console.WriteLine("Tryk [Enter].");
                Console.ReadKey();
            }
        }
        public static void Opgave47()
        {
            //Et program hvor man kan indtaste to tekster.Programmet skal så fortælle hvilken tekst der er længst.

            Console.WriteLine("Programmet undersøger, hvilken af to tekster, der er den længste.");
            Console.WriteLine();

            Console.WriteLine("Indtast tekst nr. 1:");
            int indtastningLængde1 = Console.ReadLine().Length;
            Console.WriteLine();

            Console.WriteLine("Indtast tekst nr. 2:");
            int indtastningLængde2 = Console.ReadLine().Length;
            Console.WriteLine();

            if (indtastningLængde1 == indtastningLængde2)
            {
                Console.WriteLine("Teksterne er lige lange");
            }
            else if (indtastningLængde1 > indtastningLængde2)
            {
                Console.WriteLine("Tekst nr. 1 er længst");
            }
            else
            {
                Console.WriteLine("Tekst nr. 2 er længst");
            }
        }
        public static void Opgave48()
        {
            //Program hvor man indtaster en tekst og programmet fjerner alle mellemrummene fra teksten og 
            //udskriver den.

            Console.Write("Skriv en tekst: ");
            string tekst = Console.ReadLine();
            string renTekst = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                char tegn = tekst[i];
                if (tegn != ' ')
                {
                    Console.Write("Nyt tegn tilføjes: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(tekst[i]);
                    Console.ResetColor();
                    renTekst += tekst.Substring(i, 1);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Der forsvandt et mellemrum.");
                    Console.ResetColor();
                }
                Console.WriteLine("Variablen renTekst indeholder nu: " + renTekst);

            }
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("og nu ser teksten sådan ud: ");
            Console.WriteLine(renTekst);
            Console.ReadLine();
        }
        public static void Opgave49()
        {
            //Man indtaster en tekst og programmet udskriver teksten spejlvendt/omvendt.
            Console.Write("Skriv en tekst: ");          //Her bliver der spurgt til interaktion fra bruger
            string tekst = Console.ReadLine();          //input tekst bliver sat ind i en variabel
            string nyTekst = string.Empty;              //ny variabel til omvendt tekst bliver erklæret
            for (int i = tekst.Length - 1; i >= 0; i--) //for-løkke, der skal hente et tegn ad gangen,
                                                        //og starte med sidste tegn i tekststrengen. (tekst.Length -1).
            {
                //nyTekst += tekst[i];

                nyTekst += tekst.Substring(i, 1); //her bliver bogstaver puttet ind i variablen
                                                  //nyTekst en for en bagfra
            }
            Console.WriteLine();
            Console.WriteLine("Den nye bagvendte tekst ser sådan ud: ");
            Console.WriteLine(nyTekst); //teksten bliver skrevet ud
            Console.ReadLine();
        }
        public static void Opgave50()
        {
            //et program hvor man kan indtaste en tekst og finde ud af om denne tekst findes i den anden tekst.
            string teksten = "Der var en gang en mand, der læste til en bjørn. Bjørnen elskede historier, men kunne ikke selv læse.";
            string minTekst = teksten.ToLower();
            string tekst;
            do
            {
                Console.WriteLine("Skriv et søgeord, for at finde ud af, om det er i min tekst: ");
                tekst = Console.ReadLine().ToLower();

                if (minTekst.Contains(tekst))
                {
                    Console.WriteLine("Dit søgeord findes i teksten.");
                }
                else
                {
                    Console.WriteLine("Dit søgeord findes ikke i teksten.");
                }
            } while (!minTekst.Contains(tekst));
            Console.WriteLine(teksten);
        }
    }
}

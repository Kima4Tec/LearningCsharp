using System;


namespace LearningCsharp
{
    public class Opgave51til60
    {
        public static void udskriv(string ditNavn)
        {
            Console.WriteLine(ditNavn);
        }
        public static void Opgave51()
        {
            //Udskriv en tekst fem gange
            for (int i = 1; i <= 5; i++)
            {
                udskriv("Tekst");
            }
        }

        static public void beregnbrutto(double nettobelob)
        {
            double bruttobelob = (nettobelob * 0.25) + nettobelob;
            Console.WriteLine($"Bruttobeløbet af {nettobelob:C2} er {bruttobelob:C2}");
        }
        public static void Opgave52()
        {
            //Med og uden moms

            Console.WriteLine("Her får du beregnet brutto pris på en vare. Indtast nettobeløb, som du vil finde bruttobeløb på: ");
            double nettobelob = Convert.ToDouble(Console.ReadLine());

            beregnbrutto(nettobelob);
            Console.ReadLine();
        }
        static public void Skriv(string text, string farve)
        {
            if (farve == "rød")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (farve == "gul")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (farve == "grøn")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (farve == "blå")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ResetColor();
            }
            int centerX = Console.WindowWidth / 2 - text.Length / 2;
            int centerY = Console.WindowHeight / 2;
            Console.SetCursorPosition(centerX, centerY);

            Console.WriteLine(text);
        }
        public static void Opgave53()
        {
            //Et program der har en metode som du kalder skriv. Metoden skal kaldes på denne måde:
            //Skriv(”en tekst”, ”rød”);

            Skriv("Her er en længere tekst, som jeg gerne vil have centreret", "blå");
            Console.ReadLine();
        }
        static public double rumfang(double h, double r) //formel: V = π * r * r * h
        {
            double delCyl = h * r * r;
            double rumfang = Math.PI * delCyl;
            return rumfang;
        }
        public static void Opgave54()
        {
            //Modificer ovenstående programs metode således at den beregner og rumfanget af en cylinder

            Console.Write("Indtast højde på cylinderen i cm: ");
            double højde = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast radius på cylinderen i cm: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double rumfangafcyl = rumfang(højde, radius);
            Console.Write("Rumfanget af cylinderen er {0:N2} cm³", rumfangafcyl);

            //eller man kan skrive – Alt + 252 giver ³
            //Console.Write("Rumfanget af cylinderen er {0} cm³", rumfang(højde, radius));
            // da metoden jo returnerer en værdi
            Console.ReadKey();
        }
        public static void Opgave55()
        {
            //Udregn trekants areal med ny klasse og underklasse.

            Console.Write("Indtast højde på trekanten i cm: ");
            int højde = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast grundlinje på trekanten i cm: ");
            int grundlinje = Convert.ToInt32(Console.ReadLine());
            //Du kan skrive sådan 
            Console.WriteLine("Arealet af trekanten er {0:N1} cm²", Matematik.arealTrekant(højde,
            grundlinje));
            //men da der også er lavet en underklasser, der arver alle metoder fra Matematikklassen,
            //så kan du også kalde metode sådan her:
            Console.WriteLine("Arealet af trekanten er {0:N1} cm²", Areal.arealTrekant(højde, grundlinje));


            Console.WriteLine("\n");
            Console.WriteLine("Indtast radius i cm på den cirkel du vil udregne areal på: ");
            string indRadius = Console.ReadLine();
            double r = Convert.ToDouble(indRadius);
            double cirkelAreal = Areal.arealCirkel(r);
            Console.WriteLine($"Cirklens areal er: {cirkelAreal:N2} cm²");
        }

        public static void Opgave56()
        {
            //Dette program finder gennemsnittet af temperaturer, der er  målt over 7 dage.
            double sum = 0;
            double[] temp = new double[7];
            string[] ugedage = { "mandag", "tirsdag", "onsdag", "torsdag", "fredag", "lørdag", "søndag" };

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("Indtast temperatur i Celcius for {0} : ", ugedage[i]);
                temp[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + temp[i];
            }

            Console.WriteLine("Gennemsnittet er {0:N2} grader Celcius.", (sum / 7));
            Console.ReadKey();

        }
        public static void Opgave57()
        {
            //Lav et program der finder gennemsnittet af en række karakterer, hvor man til start indtaster hvor mange 
            //karakterer man ønsker at beregne gennemsnittet af.
            Console.WriteLine("Hvor mange karakterer vil du angive?: ");
            int antalKarakterer = Convert.ToInt32(Console.ReadLine()); //skriv antal for karakterer

            string svar;
            int[] karakterer = new int[antalKarakterer]; //Her er antallet af karakterer
            int harTastetAntal = 0;
            int sum = 0;
            while (harTastetAntal < antalKarakterer)
            {
                Console.WriteLine($"Tast karakter nr. {harTastetAntal + 1}: ");
                svar = Console.ReadLine();
                if (svar == "2" || svar == "0")
                {
                    svar = svar.PadLeft(2, '0');
                }
                if (svar == "12" || svar == "10" || svar == "7" || svar == "4" || svar == "02" || svar == "00" || svar == "-3")
                {
                    karakterer[harTastetAntal] = Convert.ToInt32(svar);
                    harTastetAntal++;
                }
                else
                {
                    Console.WriteLine("Indtastningen er ugyldig. Prøv igen.");
                }
            }
            Console.WriteLine("Alle karaktererne udskrives:");
            foreach (int i in karakterer)
            {
                if (i == 2 || i == 0)
                {
                    Console.WriteLine($"{i:D2}");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            //Her lægger den alle karaktererne sammen i arrayet, der er blevet skabt);
            foreach (int k in karakterer)
            {
                sum += k;
            }
            Console.WriteLine($"Gennemsnittet er {(double)sum / antalKarakterer:N1}");
        }
        public static void Opgave58()
        {
            //I stedet for at løbe et array igennem med en for-løkke når man f.eks.skal
            //udskrive de enkelte elementer, kan man bruge denne kode.Så behøver du ikke kende arrayet´s størrelse(antal elementer / index).

            //Step 1: create an array of 3 strings.
            string[] pets = { "hund", "kat", "fugl", "fisk" };

            // Step 2: loop with the foreach keyword. 
            foreach (string value in pets)
            {
                // Step 3: access the enumeration variable. 
                Console.WriteLine("Foreach item: " + value);
            }
            Console.WriteLine();
            Console.WriteLine($"Der er {pets.Length} items i arrayet.");
            Console.ReadKey();
        }
        //Indtast og kør ovenstående program.Prøv derefter selv at ændre antallet
        //af elementer i array´et pets og kør programmet igen.
}
}

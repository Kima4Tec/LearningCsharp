using System;
using System.Data;
using System.Timers;

namespace LearningCsharp
{
    internal class Opgave11til20
    {


        public static void Opgave11()
        {
            //Console.Read og Unicode vs ASCII
            //Console.Read læser kun ét enkelt tegn fra input og returnerer en int,
            //der repræsenterer Unicode-værdien for det læste tegn.

            //Console.ReadLine læser hele input-strengen og returnerer en string

            Console.Write("Først bruger jeg Console.ReadLine. Indtast dit navn: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Nu bruger jeg Console.Read. Prøv at taste copyright-tegnet [ALT] + 184 på numpad eller \n" +
                "et andet tegn, som du vil have returneret Unicode-værdien af:");
            int readAKey = Console.Read();    
            Console.WriteLine("Unicode-værdien: " + readAKey);
            Console.WriteLine("og tegnet, som du indtastede: " + (char)readAKey);
            Console.WriteLine($"..og her er din Console.ReadLine indtastning: {navn}");

            //ASCII inkluderer 128 forskellige tegn, herunder bogstaver, tal og specielle tegn som tegnsætningstegn.
            //Unicode er et meget mere omfattende og internationalt tegnsæt, der blev udviklet i 1990'erne. Unicode inkluderer
            //over 140.000 forskellige tegn, herunder bogstaver, tal, symboler og skriftsystemer til forskellige sprog.
        }
        public static void Opgave12()
        {          
            Console.Write("Indtast beløb uden moms: kr. ");
            double udenMoms = Convert.ToDouble(Console.ReadLine());
            double medMoms = udenMoms + udenMoms * 0.25;
            Console.WriteLine($"\t Beløb med moms: {medMoms:C}");
            Console.WriteLine();
            Console.Write("Indtast beløb med moms: kr. ");
            medMoms = Convert.ToDouble(Console.ReadLine());
            udenMoms = medMoms - medMoms * 0.2;
            Console.WriteLine($"Beløb før moms: {udenMoms:C}");
        }

        //Kommatal/decimaltal
        //float (32bit reelt tal) double(64bit reelt tal) decimal (128bit reelt tal)

        //Heltal
        //byte (8bit) short (16bit) int (32bit) long (64bit)

        // operatorer, som man bruger med tal: + (plus), - (minus), * (gange), / (division), % (modulus)
        // += adderer og lægger til fx hvis a = 25; og dernæst skriver a += 10, så lægger den 10 til de 25 = 35
        // -= subtraherer og trækker fra
        // *= mulitiplicerer og tildeler ny værdi fx a= 25; a *= 2  // a = 50
        // /= dividerer og tildeler ny værdi fx a = 25; a /= 5 // a = 5
        // ++ forøger en variabel med én
        // -- formindsker en variabel med én

        public static void Opgave13()
        {
            //Fremskrivningsformlen
            //Kapitalformel: Startkapital K0, Rente p% pr.termin, Kapital K efter n terminer
            //K = ⋅K0 * (1+r)ⁿ , hvor r= 100/p
            Console.WriteLine("Vores bank giver halvårlig rentetilskrivning, og renten er 6% p.a.");
            Console.WriteLine("Hvor meget vil du sætte ind: ");
            double startKapital = Convert.ToDouble(Console.ReadLine());
            double rente = 3;
            Console.WriteLine("Hvor mange år vil du have pengene stående: ");
            double termin = Convert.ToDouble(Console.ReadLine())*2;
            double r = rente / 100;
            double KapitalK = startKapital * Math.Pow((1 + r), termin);
            Console.WriteLine($"Du startede med {startKapital:C} og har {KapitalK:C} efter {termin/2} år.");

        }
        public static void Opgave14()
        {
            //Du skal beregne og udskrive arealet og
            //omkredsen af en cirkel. Bruger skal indtaste radius.
            Console.WriteLine("Indtast radius på den cirkel du vil udregne areal og omkreds på: ");
            string indRadius = Console.ReadLine();
            double Radius = Convert.ToDouble(indRadius);
            Console.WriteLine($"Formel: cirkels areal = r{(char)178} * pi");
            double cirkelOmkreds = 2 * Radius * Math.PI;
            double cirkelAreal = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Cirkels omkreds er: {cirkelOmkreds:N2}cm\nCirklens areal er: {cirkelAreal:N2}cm{(char)178}");
        }

        public static void Opgave15()
        {
            // Find og udskriv omkredsen på en retvinklet trekant, når du kender højde og grundlinje.
            //A² + B² = C²
            //Omkredsen er lig med A+B+C
            Console.Write("Indtast højden for den trekant, som du gerne vil kende omkredsen af: ");
            string højde = Console.ReadLine();
            double a = Convert.ToDouble(højde);

            Console.Write("Indtast længden på grundlinjen for den trekant, som du gerne vil kende omkredsen af: ");
            string grundLinje = Console.ReadLine();
            double b = Convert.ToDouble(grundLinje);
            Console.WriteLine("Formel: A² + B² = C²");
            double c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));
            Double omkreds = a + b + c;
            Console.WriteLine($"Trekantens omkreds er: {omkreds:N2}cm");
        }
        public static void Opgave16()
        {
            var dato = DateTime.Now;
            int tid = dato.Hour;

            if (tid < 12)
            {
                Console.WriteLine( "God formiddag!");
            }
            else if (tid <18)
            {
                Console.WriteLine("God eftermiddag!");
            }
            else
            {
                Console.WriteLine("God aften!");
            }

            int alder = 15;
            string resultat = (alder < 18) ? "Du må ikke købe spiritus" : "Du må godt købe spiritus.";
            Console.WriteLine(resultat);


            //if (betingelse)
            //{

            //}
            //else if (anden betingelse) 
            //{
            //    Console.WriteLine();
            //}
            //else //hvis ingen af de ovenstående er sande, så køres denne
            //{
            //    Console.WriteLine();
            //}
            /*
             Sammenligningsoperatorer
                • < Mindre end
                • <= Mindre end eller lig med
                • > Større end
                • >= Større end eller lig med
                • == Lig med
                • != Ikke lig med (forskellig fra)
                Logiske operatorer
                • ! Not
                • & And
                • ^ Exclusive Or 
                • | Or
                • && And (Booelsk variabel)
                • || Or (Booelsk variabel)
             */
        }


        public static void Opgave17()
        {
            //Betingelse: Man skal være 18 år eller derover, for at kunne købe spiritus over 16,5%. 

            Console.Write("Hvis du vil købe spiritus, skal du være over 18 år.\n Hvor gammel er du?: ");
            string indAlder = Console.ReadLine();
            int alder = Convert.ToInt32(indAlder);
            if (alder < 18)
            {
                Console.WriteLine("Du er desværre ikke gammel nok til at købe spiritus over 16,5%.");
            }
            else
            {
                Console.WriteLine("Du er godkendt til at købe spiritus over 16,5%.");
            }

        }
        public static void Opgave18()
        {
            Console.WriteLine("Indtast et tal: ");
            string indEtTal = Console.ReadLine();
            int etTal = Convert.ToInt32(indEtTal);
            
            Console.WriteLine("Indtast et andet tal: ");
            string indEtAndetTal = Console.ReadLine();
            int etAndetTal = Convert.ToInt32(indEtAndetTal);

            //if (etTal == etAndetTal)
            //{
            //    Console.WriteLine("Tallene er lige store");
            //}
            //else if (etTal > etAndetTal)
            //{
            //    Console.WriteLine($"Det første tal ({etTal}) er større end det andet ({etAndetTal}), og altså størst.");
            //}
            //else
            //{
            //    Console.WriteLine($"Det første tal ({etTal}) er mindre end det andet ({etAndetTal}). Det andet er altså størst.");
            //}

            Console.WriteLine($"Det største tal er: {Math.Max(etTal, etAndetTal)}");
        }
        public static void Opgave19()
        {
            //Du er på museum, og for at finde billetprisen, skal de kende din alder
            int alder;
            Console.WriteLine("Der er forskellige priser for indgang på museet i forhold til din alder.");
            Console.Write("Indtast din alder?: ");
            alder = int.Parse(Console.ReadLine());
            int ungRabat = 65;
            int normal = 125;
            int pension = 55;

            if (alder < 18)
            {
                Console.WriteLine($"Du er under 18 år skal betale {ungRabat:C} for at komme ind.");
            }
            else if (alder >= 18 && alder <= 65)
            {
                Console.WriteLine($"Du er mellem 18 og 65 år og skal betale {normal:C} for at komme ind.");
            }
            else
            {
                Console.WriteLine($"Du er over 65 år og skal betale {pension:C} for at komme ind.");
            }
        }
        public static void Opgave20()
        {
            //I dette program spørges der til brugernavn og password.

            string brugerNavn = "Absalon";
            string password = "1234";

            Console.Write("Indtast brugernavn: ");
            string userBrugerNavn = Console.ReadLine();

            Console.Write("Indtast adgangskode: ");
            string userPW = Console.ReadLine();

            if (userPW == password && userBrugerNavn == brugerNavn)
            {
                Console.Write("Korrekt! Du har nu adgang til systemet.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Du har ikke adgang. Programmet afsluttes.");
                Console.ReadLine();
            }
        }
    }//slut class
}

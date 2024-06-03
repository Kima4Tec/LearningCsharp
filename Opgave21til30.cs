using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    internal class Opgave21til30
    {

        public static void Opgave21()
        {
//Du har fundet en webshop, hvor du kan købe t-shirts. Du skal vælge mellem 3 størrelser, og derefter hvor mange du vil have.
            string size = "";
            int antal = 0;
            int pris = 0;

            Console.WriteLine("Velkommen i US T-shirts. Vi har t-shirts i tre forskellige størrelser.");
            Console.WriteLine("Vi har størrelse (S)MALL til 120 kroner, (M)EDIUM til 160 kroner og (L)arge til 185 kroner. ");
            Console.WriteLine("Du får rabat ved køb af mere end 10 t-shirts.");
            Console.Write("Hvilken størrelse ønsker du?: ");

            size = Console.ReadLine().ToLower();

            if (size == "s")
            {
                pris = 120;
            }
            else if (size == "m")
            {
                pris = 160;
            }
            else if (size == "l")
            {
                pris = 185;
            }
            else
            {
                Console.WriteLine("Du har valgt en størrelse, som vi ikke har. Kom igen en anden gang.");
                return;
            }

            Console.WriteLine($"Du har valgt størrelse: {size.ToUpper()}");
            Console.WriteLine();

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
                else if (antal == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"Din pris er: {sum:C}");
                    Console.ReadLine();
                }
            
        }



        

        public static void Opgave22()
        {
            //Du får 10% rabat, hvis du køber for mere end 1000 kr.,
            double køb = 0;
            Console.Write("Hvor meget har du købt for?: ");
            køb = double.Parse(Console.ReadLine());

            if (køb > 1000)
            {
                Console.WriteLine("Du får 10% i rabat.");
                double rabatPris = køb - (køb * 0.1);
                Console.WriteLine($"Din pris er {rabatPris:C}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Du kan ikke få rabat.");
                Console.ReadLine();
            }
        }









        public static void Opgave23()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int j = 10;
            //do
            //{
            //    Console.WriteLine(j);
            //    j++;
            //} while (j < 20);


            //int k = 20;
            //while (k < 30)
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}


            string[] navne = { "Henrik", "Søren", "Peter" };
            foreach (string l in navne)
            {
                Console.WriteLine(l);
            }

        }



        public static void Opgave24()
        {
            //Er du medlem af klubben
            string svar = "";
            while (svar != "j" && svar != "n")
            {
                Console.WriteLine("Er du medlem af klubben? (j/n)");
                string indSvar = Console.ReadLine();
                svar = indSvar.ToLower();
                if (svar == "j")
                {
                    Console.WriteLine("Du er medlem og får 10 % i rabat.");
                }
                else if (svar == "n")
                {
                    Console.WriteLine("Du er ikke medlem og får ikke rabat.");
                }
                else
                {
                    Console.WriteLine("Du skal taste ja eller nej.");
                }
            }

        }

        public static void Opgave25()
        {
            //Dette program udskriver alle hele tal fra 1 og op til 100
            for (int i = 0; i < 101; i++)
            {
                    Console.Write(i + " ");                
            }
        }
        public static void Opgave26()
        {
            //Dette program udskriver alle hele tal fra 100 og ned til 1
            for (int i = 100; i > 0; i--)
            {
                Console.Write(i + " ");
            }
        }
        public static void Opgave27()
        {
            //Dette program udskriver alle hele tal fra 0 til 100 med spring på 5
            for (int i = 0; i < 101; i=i+5)
            {
                Console.Write(i + " ");
            }

        }
        public static void Opgave28()
        {

            //Hotelreservation

            int VValg = 0;
            int antalV = 0;
            int antalON = 0;
            double pris = 0;
            double euroKurs = 7.44;
            int[] Vpris = { 765, 980, 1250 };
            string[] room = { "enkeltværelse", "dobbeltværelse", "familieværelse" };

            Console.WriteLine("Velkommen til Hotel Sommerlys Online bestilling:");
            Console.WriteLine($"Prisen for et intimt {room[0]}: {Vpris[0]:C}");
            Console.WriteLine($"Prisen for et rart {room[1]}: {Vpris[1]:C}");
            Console.WriteLine($"Prisen for et hyggeligt {room[2]}: {Vpris[2]:C}");
            Console.WriteLine("Du kan betale i DKr eller euro.");
            Console.WriteLine("");
            Console.WriteLine("Hvilket slags værelse, vil du bestille?");
            Console.WriteLine("     - Tast 0 for enkeltværelse");
            Console.WriteLine("     - Tast 1 for dobbeltværelse");
            Console.WriteLine("     - Tast 2 for familieværelse");
            Console.WriteLine("");
            Console.Write("Indtast valg her: ");
            
            VValg = Convert.ToInt32(Console.ReadLine().ToLower());

            //Hvis bruger svarer 0,1 eller 2, går programmet videre eller er det farvel
            if (VValg == 0 || VValg == 1 || VValg == 2)
            {
                Console.WriteLine($"     Du har valgt et {room[VValg]}"); //Valget bliver sat ind i arrayet og udskrives

                Console.Write("Hvor mange værelser vil du bestille?: ");
                
                antalV = Convert.ToInt16(Console.ReadLine());
                
                if (antalV > 4) //Der er sat et max på værelsesbestilling. Bestilles der over så kommer der en fejlmeddelelse
                {
                    Console.Write("Så mange værelser er der desværre ikke ledige. Du kan højst bestille 3 værelser. ");
                    do
                    {
                        Console.Write("Hvor mange værelser vil du bestille?: ");
                        antalV = Convert.ToInt16(Console.ReadLine());//valg bliver konverteret til integer

                    } while (antalV > 4);
                }
                Console.WriteLine($"     Du har bestilt {antalV} værelser.");
                Console.Write("Hvor mange overnatninger vil du have?: ");
                
                antalON = Convert.ToInt16(Console.ReadLine());//valg bliver konverteret til integer
                
                Console.WriteLine($"     Du har bestilt {antalON} overnatninger.");
                Console.WriteLine("");
                double Vprisen = Convert.ToDouble(Vpris[VValg]);
                
                pris = antalV * antalON * Vprisen;
                
                Console.WriteLine($"´Din pris for {antalV} x {room[VValg]} med {antalON} overnatninger er: {pris:C}.");
                double euroPris = pris / euroKurs;
                Console.WriteLine($"Din pris i euro er: {euroPris:N2} euro.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White; //skift skriftfarve for at gøre opmærksom på vigtig indtastning
                Console.WriteLine("Tast G for at godkende bestillingen og ellers afbestilles reservationen. ");
                string Godkend = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (Godkend == "g")
                {
                    Console.WriteLine("Tak for bestillingen. På gensyn i Hotel Sommerly!");
                }
                else
                {
                    Console.WriteLine("Du valgte ikke at bestille. På gensyn. Vi håber at du vil vælge os en anden gang.");
                }
            }
            else
            {
                Console.WriteLine("Dit valg er ugyldigt. Bestillingen afbrydes. På gensyn. Vi håber at du vil vælge os en anden gang.");
            }
            Console.ReadKey();
        }
    }
}

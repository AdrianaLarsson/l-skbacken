using System;

namespace Arraylotterirandomforeach
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Lottobollar . jag ska be användaren skriva in tio tal. 
            */
            Console.WriteLine(" Vill du vinna på lotteri? ");// Frågar anvädaren om hen vill vinna på lotteri
            Console.WriteLine(" Du skall välja och skriva tal mellan 0 - 25 rimliga nummer,");// Hen ska välja tal mellan 0 - 25
            Console.WriteLine(" Om du matchar ett av nummerna så har du vunnit ");// Om en av alla tio tal som anvädaren skriver in och matchar med slumptalet så vinner hen och det skrivs ut.


            Console.WriteLine(" Tryck på enter för att fortsätta! ");// användaren bes att trycka på enter för att fortsätta!
            Console.ReadLine();

            Console.WriteLine("Skriv in tal 1");//anvädaren skriver in tal ett och skriver resterande tal, till tal tio.
            string inmatat = Console.ReadLine();
            int userguess1 = int.Parse(inmatat);

            Console.WriteLine("Skriv in tal 2");
            string inmatat2 = Console.ReadLine();
            int userguess2 = int.Parse(inmatat2);

            Console.WriteLine("Skriv in tal 3");
            string inmatat3 = Console.ReadLine();
            int userguess3 = int.Parse(inmatat3);

            Console.WriteLine("Skriv in tal 4");// inmatning av invädaren alla tio nummer
            string inmatat4 = Console.ReadLine();
            int userguess4 = int.Parse(inmatat4);

            Console.WriteLine("Skriv in tal 5");
            string inmatat5 = Console.ReadLine();
            int userguess5 = int.Parse(inmatat5);

            Console.WriteLine("Skriv in tal 6");
            string inmatat6 = Console.ReadLine();
            int userguess6 = int.Parse(inmatat5);

            Console.WriteLine("Skriv in tal 7");
            string inmatat7 = Console.ReadLine();
            int userguess7 = int.Parse(inmatat7);

            Console.WriteLine("Skriv in tal 8");
            string inmatat8 = Console.ReadLine();
            int userguess8 = int.Parse(inmatat8);

            Console.WriteLine("Skriv in tal 9");
            string inmatat9 = Console.ReadLine();
            int userguess9 = int.Parse(inmatat9);

            Console.WriteLine("Skriv in tal 10");
            string inmatat10 = Console.ReadLine();
            int userguess10 = int.Parse(inmatat10);// sista tal skrivs in
            Console.WriteLine(" Du skrev " + userguess1 + ", " + userguess2 + ", " + userguess3 + ", " + userguess4 + ", " + userguess5 + ", " + userguess6 + ", " + userguess7 + ", " + userguess8 + ", " + userguess9 + " och talet " + userguess10);
            // här kommer det var anvädaren skrivit in och kommer ut vilka nummer hen valt.
            // Skapar vektor 
            int[] userguess = new int[5];




            // tilldela vektorn element olika värde genom index:
            userguess[0] = 20;
            userguess[1] = 8;
            userguess[2] = 25;
            userguess[3] = 6;
            userguess[4] = 23;

            //här skapas randon numret och slumpas fram när anvädaren har skrivit alla valda tio siffror.
            Random random = new Random();
            int number = random.Next(userguess.Length);
            System.Console.WriteLine("Slumptalet är " + userguess[number]);

            // använder mig av bool och foreach för att anvädaren ska veta om hen har vunnit eller inte

            foreach (var a in userguess)
            {



                if (userguess1 == userguess[number] || userguess2 == userguess[number] || userguess3 == userguess[number] || userguess4 == userguess[number] || userguess4 == userguess[number] || userguess5 == userguess[number] || userguess6 == userguess[number] || userguess7 == userguess[number] || userguess8 == userguess[number] || userguess9 == userguess[number] || userguess10 == userguess[number])


                {


                    Console.WriteLine("Härligt du vann!");
                    break;
                }


                else
                {


                    Console.WriteLine("Tyvärr, fel. Bättre lycka nästa gång!");

                    break;
                    Console.ReadKey();
                }

            }



            /*int userguess;
             *   Console.WriteLine(" Skriv in 5 tal");
            userguess = int.Parse(Console.ReadLine());

            Console.WriteLine("Tal 1");
            userguess = int.Parse(Console.ReadLine());
            Console.WriteLine("Tal 2");
            userguess = int.Parse(Console.ReadLine());
            Console.WriteLine("Tal 3");
            userguess = int.Parse(Console.ReadLine());
            Console.WriteLine("Tal 4");
            userguess = int.Parse(Console.ReadLine());
            Console.WriteLine("Tal 5");
            userguess = int.Parse(Console.ReadLine());


        }






    //foreach: bra för att läsa ur vektor från början till slut

    /* foreach(int minabollar in boll)
     {
         Console.WriteLine(minabollar);

     } */

            //for
            // alla loopar består av tre saker: startvärde, villkor och förändring



        }
    }

}

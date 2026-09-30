using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Be användaren att ange en summa pengar i SEK.
            Console.Write("Ange en summa pengar i SEK: ");
            string inputText = Console.ReadLine();
        double summaSek = Convert.ToDouble(inputText);
        //Ange en lista över tillgängliga valutor (t.ex. EUR, GBP, JPY,USD).
        Console.WriteLine("tillgänliga valutor: USD, EUR, GBP");
            Console.Write("Ange en valuta att konvertera till: ");
            string valuta = Console.ReadLine().ToUpper();
            double vaxelkurs;   
            double resultat;
            // Använd en switch-sats för att hantera valutaomvandlingen.
            switch (valuta)
            {
                case "USD":
                    vaxelkurs = 0.11; // Exempel växelkurs
                    resultat = summaSek * vaxelkurs;
                    Console.WriteLine($"{summaSek} SEK är {resultat} USD");
                    break;
                case "EUR":
                    vaxelkurs = 0.10; // Exempel växelkurs
                    resultat = summaSek * vaxelkurs;
                    Console.WriteLine($"{summaSek} SEK är {resultat} EUR");
                    break;
                case "GBP":
                    vaxelkurs = 0.09; // Exempel växelkurs
                    resultat = summaSek * vaxelkurs;
                    Console.WriteLine($"{summaSek} SEK är {resultat} GBP");
                    break;
                default:
                    Console.WriteLine("Ogiltig valuta.");
                    break;
            }

            


        }
    }
}











using System;
using  System.Text;

namespace NumbersGame
{
    class Program
    { // Emma Hjalmarsson Wahlström
      // SUT22
        public static void Main(string[] args)
        {
            // I start my numbersgame with giving name to my varibles and welcome the user
            Random rnd = new Random();
            int nummer = rnd.Next(1, 20);
            int numOfGuess = 5;
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får " + numOfGuess + " försök.");
            NumGame(nummer, numOfGuess); // Call on method

        }
        public static bool NumGame(int nummer, int numOfGuess) // My method, were the actual game is
        {
            // Start with a bool, that will check if answer is right or wrog, if wrong the user is going through the (if) loop 5 times
            bool right = false;
            do
            {
                string s = Console.ReadLine();
                int i = int.Parse(s);
                /*With a if statmements I check if answer is right, wrong and if wrong, is it to high or low.
                User also get a notis of how many chances thet have left*/
                if (i == nummer)
                {
                    Console.WriteLine("Du klarade det!");
                    break;
                }
                else if (numOfGuess == 1)
                {
                    Console.WriteLine("Tack för att du spelade men du har gjort för många försök");
                    right = true;
                }
                else if (i > nummer)
                {
                    numOfGuess--;
                    Console.WriteLine("Tyvärr gissade du för högt, gissa något lägre!");
                    Console.WriteLine("Du har " + numOfGuess + " försök kvar");
                }
                else if (i < nummer)
                {
                    numOfGuess--;
                    Console.WriteLine("Tyvärr gissade du för lågt, gissa något högre! Du har " + numOfGuess + " försök kvar");
                }

            } while (right == false);

            return true;
        }

    }
}

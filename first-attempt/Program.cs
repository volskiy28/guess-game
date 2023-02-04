internal class Program
{

 

    private static void Main(string[] args)
    {
        Random r = new Random();

        int winNum = r.Next(0, 100);

        bool win = false;

        do
        {
            Console.WriteLine("Gues the number from 0 to 100:");

            string guesNum = Console.ReadLine();

            int gues = int.Parse(guesNum);

            if (gues > winNum)
            {
                Console.WriteLine("It's too high, gues lower num");

            }
            else if (gues < winNum)
            {
                Console.WriteLine("It's too low, gues higher num");
            }
            else if (gues == winNum)
            {
                Console.WriteLine("You won");
                win = true;
            }

        } while (win == false);

    }

    
}


namespace Text_Adventure
{
    internal class Program
    {
        public Program()
        {
        }

        public static int SPEED { get; private set; }

        private static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            Console.WriteLine("Welcome to Hunter's World in a chill room");
            Console.WriteLine("What room do you like to go in");
            Console.WriteLine("VGD | ANI | CSN | EET");

            string input = Console.ReadLine();
            if (input == "CSN")
            {
                return;
            }
            Console.WriteLine("What is your favorite video gmae");
            Console.WriteLine("Madden | Ncaa Football | Nascar | Mario Kart");
            Console.WriteLine("How long have you played the game for");



            {
                if (input == "ANI")
                {
                    Console.WriteLine("How much points or spots have you gained");
                    Console.WriteLine("What difficulty is the game on");
                    Console.WriteLine("Easy | Medium | Pro | Hard | Exsteme");
                    Console.WriteLine("How many players or cars are their");
                }
                if (input == "EET")
                {
                    Console.WriteLine("What is the final boss or the final race");
                    Console.WriteLine("What the skills you need to beat the game");
                    Console.WriteLine("What are the ablites to each player or car");
                    Console.WriteLine("How do the abilites work for the game");

                }
                if (input == "Goals")
                {
                    Console.WriteLine("What is the goal to beat the game");
                    Console.WriteLine("Is it to get past level 1");
                    Console.WriteLine("Is is to get past level 2");
                }
                if (input == "Ponints")
                {
                    Console.WriteLine("5 | 9 | 10");
                    Console.WriteLine("First place 10 points");
                    Console.WriteLine("Second place 9 points");
                    Console.WriteLine("Thrid place 5 points");
                }
                SPEED = 195;
                Console.WriteLine("Cars going 195 mph");
                Console.WriteLine("Their is a big wreak on the tack");
                Console.WriteLine();
            }

        }



        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
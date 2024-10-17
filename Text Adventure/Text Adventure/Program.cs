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
            /*if (string.IsNullOrEmpty(args[0]))
            {
                throw new ArgumentException($"'{nameof(args)}' cannot be null or empty.", nameof(args));
            }*/

            ArgumentNullException.ThrowIfNull(args);

            bool dueLoop = true;
            while (dueLoop)
            {
                Console.WriteLine("Welcome to Hunter's World in a chill room");
                Console.WriteLine("What room do you like to go in");
                Console.WriteLine("VGD | ANI | CSN | EET");

                string input = Console.ReadLine();
                if (input == "CSN")
                {
                    Console.WriteLine("What is your favorite video gmae");
                    Console.WriteLine(" Nascar | Mario Kart");

                    input = Console.ReadLine();
                    Console.WriteLine("How long have you played the game for");
                }
                if (input == "ANI")
                {
                    Console.WriteLine("How much points or spots have you gained");
                    Console.WriteLine("What difficulty is the game on");
                    Console.WriteLine("Easy | Medium | Pro | Hard | Exsteme");
                    input = Console.ReadLine();

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
                if (input == "Speed 95")
                {
                    Console.WriteLine("Cars going 95 mph");
                    Console.WriteLine("Their is a big wreak on the tack");
                    Console.WriteLine("Avoid the wreak and not get any damaged");
                }

                if (input == "Skills")
                {
                    Console.WriteLine("Sam needs to his racing line at bottom of the track");
                    Console.WriteLine("Can the player make a come back from starting dead last");
                    Console.WriteLine("Dose the player need to start at the back of the field");
                    Console.WriteLine("");
                    _ = _ = Thread.Yield();
                }
                if (input == "TargetTime")
                {
                    Console.WriteLine(value: false);
                    Console.WriteLine("But the weather sucks and the is wet");
                    Console.WriteLine("""(_____)""");
                    Console.WriteLine("But");
                }
                if (input == "Rng")
                {
                    Random rng = new Random();
                    Console.WriteLine(rng.Next(1, 40));
                }
                if (input == "StatsSetup")
                {
                    Console.WriteLine("I know the car has 750 horse power");
                    Console.WriteLine("That most cars offer just north of two degrees of negative camber at the rear");
                    Console.WriteLine("The manufacturers try to get a competitve advantage");
                    Console.WriteLine("The tire psi needs to be 25 psi on each side of the car");
                }
                if (input == "Objective")
                {
                    Console.WriteLine("Get to the start finish line");
                    Console.WriteLine("Try not to die or filp up side down");
                    _ = Console.ReadLine();

                }
                else if (input == "Skill issue Bob")
                {
                    Console.WriteLine("                     __                        ");
                    Console.WriteLine("                     00                         ");
                    Console.WriteLine("                    |--|                           ");
                    Console.WriteLine("""                 {----}                            """);
                }
                else if (input == "Damage")
                {
                    Console.WriteLine("Player gets hit by a green shell");
                    Console.WriteLine(value: "Blue shell 99 damage");
                    Console.WriteLine("Player gets Mario karted");
                    Console.WriteLine("Blue shell | Red shell | Green shell | Banana | Shock");
                }
                else if (input == "color")
                {
                    Console.WriteLine(Console.ForegroundColor);
                    Console.WriteLine(false);
                    Console.WriteLine(CancellationToken.None);
                }
                if(input == "exit")
                {
                    dueLoop = false;
                }
            }


        }

        private static void Player1(string v)
        {
            Player1("""< _ >""");

        }

        private static void Player(string value)
        {
            Console.WriteLine("How good is the player");
            Console.WriteLine("Dose the player need to start at the back of the field");
            Console.WriteLine("""Can the player make a come back from starting dead last""");
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

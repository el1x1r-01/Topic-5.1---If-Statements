namespace Topic_5._1___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            
            int people = 20;
            int cats = 30;
            int dogs = 15;

            Console.WriteLine("People: " + people + ", Dogs: " + dogs + ", Cats: " + cats);
            Console.WriteLine("");

            if (people < cats)
            {
                Console.WriteLine("Too many cats! The world is doomed!");
                Console.WriteLine("");
            }

            if (people > cats)
            {
                Console.WriteLine("Not too many cats! The world is saved!");
                Console.WriteLine("");
            }

            if (people < dogs)
            {
                Console.WriteLine("So many dogs! The world is drooled on!");
                Console.WriteLine("");
            }

            if (people > dogs)
            {
                Console.WriteLine("Not enough dogs! The world is dry!");
                Console.WriteLine("");
            }

            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();

            dogs += 5;

            Console.WriteLine("People: " + people + ", Dogs: " + dogs + ", Cats: " + cats);
            Console.WriteLine("");

            if (people >= dogs)
            {
                Console.WriteLine("People are greater than or equal to dogs.");
            }

            if (people <= dogs)
            {
                Console.WriteLine("People are lesser than or equal to dogs");
            }

            if (people == dogs)
            {
                Console.WriteLine("People are dogs.");
            }

            Console.WriteLine("");
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();

            //part 2

            string dinosaur;
            Console.WriteLine("What dinosaur is famous for having three large horns?");
            
            dinosaur = Console.ReadLine();

            Console.WriteLine("");

            if (dinosaur.ToLower() == "triceratops") //ToLower converts the user's input to lowercase so that if they type TRICERATOPS it is still correct
            {
                Console.WriteLine("You are correct!");
            }

            else
            {
                Console.WriteLine("Incorrect! The answer was: 'triceratops'.");
            }

            Console.WriteLine("");
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();

            //part 3: programming tasks

            //task 1

            string magicWord;

            Console.WriteLine("What's the magic word?");

            magicWord = Console.ReadLine();

            Console.WriteLine("");

            if (magicWord.ToLower() == "please")
            {
                Console.WriteLine("That is correct!");
            }

            else
            {
                Console.WriteLine("Incorrect! The magic word is: 'please'.");
            }

            Console.WriteLine("");
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();

            //task 2

            string name;
            int age;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("How old are you, " + name + "?");
            Int32.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("");

            if (age < 16)
            {
                Console.WriteLine("You can't drive, " + name + "!");
            }

            if (age < 18)
            {
                Console.WriteLine("You can't vote, " + name + "!");
            }

            if (age < 25)
            {
                Console.WriteLine("You can't rent a car, " + name + "!");
            }

            if (age >= 25)
            {
                Console.WriteLine("You can do anything legal, " + name + "!");
            }

            Console.WriteLine("");
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();

            //task 3

            int freezingTemp;

            Console.WriteLine("Enter the freezing temperature of water.");
            Int32.TryParse(Console.ReadLine(), out freezingTemp);

            Console.WriteLine("");

            if (freezingTemp == 0)
            {
                Console.WriteLine("0 degrees celcius is correct!");
            }

            if (freezingTemp == 32)
            {
                Console.WriteLine("32 degrees fahrenheit is correct!");
            }

            if (freezingTemp == 273.2)
            {
                Console.WriteLine("273.2 degrees kelvin is correct!");
            }

            else
            {
                Console.WriteLine("Incorrect! The accepted answers would have been: " +
                    "0 degrees celcius, 32 degrees fahrenheit, or 273.2 degrees kelvin.");
            }

            Console.ReadLine();
        }
    }
}

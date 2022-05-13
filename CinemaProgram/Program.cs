class program
{
    static List<int> myList = new List<int>();
    int price;
    int age;

    static void Main(string[] args)
    {
        Console.WriteLine("*@*@* Hello, and welcome to the Cinema program. Please Navigate though the following command numbers *@*@* ");
        Task.Delay(50);
        Console.WriteLine("0. for quit");
        Console.WriteLine("1. for price information");
        Console.WriteLine("2. calculate all persons which will attend. Total price will be given. ");
        string option = (Console.ReadLine());
        // Räknar summan av alla bio biljettter // int total = myList.Sum();


        {
            bool success = false;

            switch (option)
            {
                case "0":
                    Console.WriteLine("*Quitting the program*");
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Enter your age: ");
                    var age = int.Parse(Console.ReadLine());
                    var price = AddAge(age);
                    
                    break;

                case "2":
                    Console.WriteLine("Printing program ");
                    PrintOut10TimesString();
                    break;

                case "3":
                    Console.WriteLine("you are at stage 3");

                    break;

                case "4":
                    Console.WriteLine("you are at stage 3");

                    break;

                default:
                    Console.WriteLine("Wrong command. Please re-enter your command");
                    break;
            }
            while (!success) ;
        }

    }


    public static int AddAge(int age)
    {
        if (age < 20)
        {
            Console.WriteLine("You qualify for youth price. 80 SEK");
            return 80;
        }
        if (age > 64)
        {
            Console.WriteLine("You Qualify for pensioner price. 90 SEK");
            return 90;
        }
        else
        {
            Console.WriteLine("You qualify for Standard price. 120 SEK");
            return 120;
        }
    }


    public static void PrintOut10TimesString()
    {
        bool success = false;

        do
        {

            Console.WriteLine("Enter your desired text to print it out 10 times: ");
            string text = Console.ReadLine();

            Console.WriteLine($"Enter amout of times to print : {text}");
            if (int.TryParse(Console.ReadLine(), out int number))
            {

                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine($"input: {i}, {text}");

                }
            }

            else
            {
                Console.WriteLine("");
            }
        } while (success);

    }

}


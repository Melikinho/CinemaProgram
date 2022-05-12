class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*@*@* Hello, and welcome to the Cinema program. Please Navigate though the following command numbers *@*@* ");
        Task.Delay(50);
        Console.WriteLine("0. for quit");
        Console.WriteLine("1. for price information");
        Console.WriteLine("2. calculate all persons which will attend. Total price will be given. ");
        int option = Int32.Parse(Console.ReadLine());
        int result = 0;
        int age;
        int person;
        List<int> myList = new List<int>();
        // Räknar summan av alla bio biljettter // int total = myList.Sum();

        do
        {

            switch (option)
            {
                case 0:
                    Console.WriteLine("*Quitting the program*");
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Enter your age: ");
                    Task.Delay(500);
                    AddAge();
                    break;

                case 2:
                    Console.WriteLine("you are at stage 2");
                    break;
                
                case 3:
                    Console.WriteLine("you are at stage 3");
                    
                    break;
                
                case 4:
                    Console.WriteLine("you are at stage 3");

                    break;

                default:
                    Console.WriteLine("Wrong command. Please re-enter your command");
                    break;
            }

        }
        while (false);
    }
    public static void AddAge() {
        List<int> myList = new List<int>();


        int age = int.Parse(Console.ReadLine());
        if (age < 20)
        {
            Console.WriteLine("You qualify for youth price. 80 SEK");
            myList.Add(age);
        }
            if (age > 64)
            {
                Console.WriteLine("You qualify for pensioner price. 90 SEK");
                myList.Add(age);
            }
        else
        {
            Console.WriteLine("You qualify for Standard price. 120 SEK");
            myList.Add(age);
        }
    }

    public void CalculateAge()
    {
        List<int> myList = new List<int>();
        Console.WriteLine("Under Construction");
    }
}
    

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
                    Task.Delay(50);
                    AddAge();
                    break;

                case 2:
                    Console.WriteLine("you are at stage 2");
                    break;
                
                case 3:
                    
                    break;
                
                case 4:
                    
                    break;

                default:
                    Console.WriteLine("Wrong command. Please re-enter your command");
                    break;
            }

        }
        while (false);
    }
    public static void AddAge() {
        
        int age = int.Parse(Console.ReadLine());
        if (age < 20) 
        {
            Console.WriteLine("You qualify for youth price. 80 SEK");

        }   if(age > 64)
            {
                Console.WriteLine("You qualify for pensioner price. 90 SEK");
            }
        else {
            Console.WriteLine("You qualify for Standard price. 120 SEK");
        }
        
    }
   /* public static void CalculateAge(int age)  //TEST METHOD//
    {
        string age1 = Convert.ToString(age);
        int sum = 0;
        for (int i = 0; i < age1.Length; i++)
            sum += Convert.ToInt32(age1.Substring(i, 1);
    }  */
}
    

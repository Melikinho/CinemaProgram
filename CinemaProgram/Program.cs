using System;
using System.Collections.Generic;
class program
{
    int price;
    int age;

    static void Main(string[] args)
    {
        Console.WriteLine("*@*@* Hello, and welcome to the Cinema program. Please Navigate though the following command numbers *@*@* ");
        Task.Delay(50);
        Console.WriteLine("0. For Quit");
        Console.WriteLine("1. For Price Information");
        Console.WriteLine("2. Calculate persons & total price for attended people ");
        Console.WriteLine("3. Print out input text x amount of times");
        Console.WriteLine("4. Split text");
        Console.WriteLine("5. How many people will attend total ");
        string option = Console.ReadLine();
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
                    Console.Clear();
                    Console.WriteLine("Enter your age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine(BuyTicket());
                    break;

                //Console.WriteLine("Enter your age: ");
                //var age = int.Parse(Console.ReadLine());
                //var price = AddAge(age);


                case "2":
                    //int totalPrice;
                    Console.Clear();
                    Console.WriteLine("Buy tickets for the crowd");
                    //BuyTicket();
                    Crowd();
                    
                    //Console.WriteLine(BuyTicket);
                    

                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Printing program ");
                    PrintOut10TimesString();

                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Write a meaning with minimum 3 words and the program will shouw you the third word");
                    Split();

                    break;
                //case "5":
                //    Console.Clear();
                //    Console.WriteLine("How many people in the crowd will attend the Cinema?");
                //    int totalPrice = 0;
                //    int input = int.Parse(Console.ReadLine());
                //    Console.WriteLine("You Entered {0}", input);
                //    for (int i = 0; i < input; i++)
                //    {
                //        Console.WriteLine($"Those will attend: {input}");
                //        BuyTicket();

                //    }

                //    //Hur många i sällakapet?
                //    //Loppa och anropa CalculatePersonsTotalPrice
                //    //int totalprice = 0;


                //    //Skriv ut totalsumman

                //    break;

                default:
                    Console.WriteLine("Wrong command. Please re-enter your command");
                    break;
            }
            while (!success) ;
        }

    }
    public static int Add(int nr1, int nr2)
    {
        int sum = nr1 + nr2;
        return sum;
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

    static int BuyTicket()
    {
        const int youthPrice = 80;
        const int pensionerPrice = 90;
        const int standardPrice = 120;

        string ageInput = "";
        int age;
        do
        {
            Console.WriteLine("How old are the people attending to the Cinema?: ");
            ageInput = Console.ReadLine();

        } while (!int.TryParse(ageInput, out age));

        if (age < 20)
        {
            Console.WriteLine("Your price will be 80 SEK - Youth price");
            return youthPrice;

        }
        else if (age > 64)
        {
            Console.WriteLine("Your price will be 90 SEK Pensioner price");
            return pensionerPrice;
        }
        else
        {
            Console.WriteLine("Your price will be 120 SEK standard price");
            return standardPrice;

        } while (true) ;

    }

    public static void Split()
    {
        do
        {
            Console.Write("Write your three words: ");
            string word = Console.ReadLine();
            string[] letter = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (letter.Length < 3)
            {
                Console.WriteLine("You must write atleast 3 words");
                break;
            }
            else
            {
                Console.WriteLine("The third last word is:" + letter[2]);
                break;
            }
        } while (true);

    }

    // Crowd > Crowd
    // Crowd(Crowd(Crowd))
    static void Crowd()
    {
        // förbättring, TryParse och gräns hur många personer

        Console.WriteLine("How many People in the crowd?: ");
        int input = Int32.Parse(Console.ReadLine());

        if(input > 8)
        {
            Console.WriteLine("max 8 besökare");
            
        }
        int sum = 0;
        
        for (int i = 0; i < input; i++)
        {
            sum += BuyTicket();

        }
        Console.WriteLine("Total persons in the crowd: " + input);
        Console.WriteLine($"Total cost for the crowd: {sum}");
    }
}

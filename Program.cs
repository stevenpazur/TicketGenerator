using System;

namespace TicketGenerator
{
    class Program
    {
        const int SENIOR_AGE = 65;
        const int CHILD_AGE = 12;

        static int userAge = 20;
        static int ticketPrice = 14;

        static bool isStudent = true;

        static void Main(string[] args)
        {
            RunThat();
        }

        static void RunThat()
        {
            try
            {
                Console.WriteLine("Enter your age.");

                string input = Console.ReadLine();

                if (Int32.TryParse(input, out int value))
                {
                    value = Int32.Parse(input);
                    userAge = value;
                }
                else
                {
                    throw new Exception("Not a valid number.");
                }

                isStudent = userAge <= CHILD_AGE;

                if (userAge < 0)
                {
                    throw new Exception("Enter a non-negative number.");
                }

                if (userAge >= SENIOR_AGE)
                {
                    ticketPrice = 10;
                }
                else if (userAge <= CHILD_AGE || isStudent)
                {
                    ticketPrice = 8;
                }
                else{
                    ticketPrice = 14;
                }

                Console.WriteLine("Your ticket price is: $" + ticketPrice);
                RunThat();
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter a correct age: " + e.Message);
            }
        }
    }
}

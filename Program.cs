using System;

namespace TicketGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SENIOR_AGE = 65;
            const int CHILD_AGE = 12;

            int userAge = 20;
            int ticketPrice = 14;

            bool isStudent = true;

            try {
                if(userAge < 0){
                    throw new Exception();
                }

                if (userAge >= SENIOR_AGE){
                    ticketPrice = 10;
                } else if (userAge <= CHILD_AGE){
                    ticketPrice = 8;
                }

                Console.WriteLine("Your ticket price is: " + ticketPrice);
            } catch (Exception e) {
                Console.WriteLine("Enter a correct age " + e.Message);
            }
            

            if(isStudent){
                ticketPrice = 8;
            }

        }
    }
}

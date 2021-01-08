using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To SilverBird Cinema Galleria! Tickets are N5 Please, Kindly Insert Cash");
            int change;
            
            int cash = Convert.ToInt32(Console.ReadLine());

            for (int count = 0; count < 2; count++)
            {
                if (cash == 0)
                {
                    Console.WriteLine("Error... Please Retry... who no get money no dey watch movie, Go work");
                    cash = Convert.ToInt32(Console.ReadLine());
                }

            }
                 if (cash > 0 && cash < 5)
                {
                    Console.WriteLine("That's Not Enough Money Please... Tickets are 5$!!");
                }
            

                else if ( cash == 5)
                {
                    Console.WriteLine("Here's Your Ticket, Do Have a Nice Time");
                }
                else if (cash > 5)
                {
                   change=cash-5;

                    Console.WriteLine(" Here's Your Ticket  and your N{0} Change. Do enjoy your movie ",change);
                }

               else 
               {
                Console.WriteLine("Your trial time is over, as You have entered an invalid Amount three(3) times.Good Bye");             
               }
            


            
             

        }
    }
}
        

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekend_Box_Office
{
    class Program
    {
        // Calculate the average of "weekend gross" for all top 15 films.
        static void Top_15()
        {
            // The only variable needed for this is the weekend gross.
            double[] movie_weekend_gross = new double[15];

            // Asks for the weekend gross of the top 15 ranked films.
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Please enter the amount that rank {0} earned this weekend: ", i+1);
                string temp = Console.ReadLine();
                movie_weekend_gross[i] = Convert.ToDouble(temp);
            }

            double total = 0;

            // Go through the array and add it to the total.
            for (int i = 0; i < 15; i++)
            {
                total += movie_weekend_gross[i];
            }

            // All them added up divided by the amount of films.
            decimal answer = Convert.ToDecimal(total / 15);
            Console.WriteLine();
            Console.WriteLine("The average weekend gross of all the top 15 films is £{0}", answer);
        }

        static void All_UK_USA()
        {
            // Calculates the average ‘weekend gross’ of all UK/USA origin films
            Console.WriteLine();
        }

        static void How_many_viewings()
        {
            // Given an average ticket price of £8.00, how many ‘viewings’ of ‘Disney’s Christopher Robin’ were made in this week? 
            Console.WriteLine();
        }

        static void Previous_week()
        {
            //  The ‘weekend gross’ figures for ‘Mamma Mia: Here We Go Again’ and ‘Disney’s Christopher Robin’ for the previous week. 
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1) Weekend Gross of the Top 15.");
            Console.WriteLine("2) Weekend Gross of films from the UK and USA.");
            Console.WriteLine("3) How many viewings of Disney's Christopher Robin?");
            Console.WriteLine("4) Weekend gross for the last week.");
            Console.Write("Where would you like to go? ");
            string menu_answer = Console.ReadLine();

            switch (menu_answer)
            {
                case "1":
                    Top_15();
                    break;
                case "2":
                    All_UK_USA();
                    break;
                case "3":
                    How_many_viewings();
                    break;
                case "4":
                    Previous_week();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid menu option.");
                    Console.WriteLine();
                    Main(args);
                    break;
            }
            
            Console.ReadKey();
            Console.WriteLine();
            Main(args);
        }
    }
}

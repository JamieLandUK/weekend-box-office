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

        // Calculates the average ‘weekend gross’ of all UK/USA origin films
        static void All_UK_USA()
        {
            string[] movie_origin = new string[15];
            double[] movie_weekend_gross = new double[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Please enter the amount that rank {0} earned this weekend: ", i + 1);
                string temp = Console.ReadLine();
                movie_weekend_gross[i] = Convert.ToDouble(temp);

                Console.Write("What is the country of origin? ");
                movie_origin[i] = Console.ReadLine();

                Console.WriteLine();
            }

            double total = 0;
            int amount_of_numbers = 0;

            for (int i = 0; i < 15; i++)
            {
                if (movie_origin[i] == "UK/USA")
                {
                    total += movie_weekend_gross[i];
                    amount_of_numbers++;
                }
            }

            decimal answer = Convert.ToDecimal(total / amount_of_numbers);
            Console.WriteLine("The average weekend gross of all the top 15 films is £{0}", answer);
        }

        // Given an average ticket price of £8.00, how many ‘viewings’ of ‘Disney’s Christopher Robin’ were made in this week?
        static void How_many_viewings()
        {
            Console.Write("What is the Weekend Gross of 'Disney's Christopher Robin'? ");
            string s_weekend_gross = Console.ReadLine();
            double weekend_gross = Convert.ToDouble(s_weekend_gross);

            Console.WriteLine("If the average ticket price is £8.00...");
            Console.WriteLine("There were {0} tickets sold for 'Disney's Christopher Robin'.", weekend_gross / 8);
            Console.WriteLine();
        }

        //  The ‘weekend gross’ figures for ‘Mamma Mia: Here We Go Again’ and ‘Disney’s Christopher Robin’ for the previous week. 
        static void Previous_week()
        {
            Console.Write("What is the weekend gross 'Disney's Christopher Robin'? ");
            string s_cr_gross = Console.ReadLine();
            double cr_gross = Convert.ToDouble(s_cr_gross);

            Console.Write("And the percentage change from last week? ");
            string s_cr_change = Console.ReadLine();
            double cr_change = 0;

            if (s_cr_change[0] == '-')
            {
                string true_number = s_cr_change.Substring(1);
                string prefix = "1.";
                string full_number = prefix + true_number;
                cr_change = Convert.ToDouble(full_number);
            }
            else
            {
                string prefix = "0.";
                string full_number = prefix + s_cr_change;
                cr_change = Convert.ToDouble(full_number);
            }

            double answer1 = cr_gross * cr_change;

            Console.WriteLine(); // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

            Console.Write("What is the weekend gross 'Mamma Mia: Here we Go Again!'? ");
            string s_mm_gross = Console.ReadLine();
            double mm_gross = Convert.ToDouble(s_mm_gross);

            Console.Write("And the percentage change from last week? ");
            string s_mm_change = Console.ReadLine();
            double mm_change = 0;

            if (s_mm_change[0] == '-')
            {
                string true_number = s_mm_change.Substring(1);
                string prefix = "1.";
                string full_number = prefix + true_number;
                mm_change = Convert.ToDouble(full_number);
            }
            else
            {
                string prefix = "0.";
                string full_number = prefix + s_mm_change;
                mm_change = Convert.ToDouble(full_number);
            }

            double answer2 = mm_gross * mm_change;

            Console.WriteLine("Last week's gross figures for 'Disney's Christopher Robin': {0}", answer1);
            Console.WriteLine("Last week's gross figures for 'Mamma Mia: Here we Go Again!': {0}", answer2);

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
                    Console.WriteLine();
                    Top_15();
                    break;
                case "2":
                    Console.WriteLine();
                    All_UK_USA();
                    break;
                case "3":
                    Console.WriteLine();
                    How_many_viewings();
                    break;
                case "4":
                    Console.WriteLine();
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

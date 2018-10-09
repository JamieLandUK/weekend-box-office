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
        static List<string> l_rank = new List<string>(); // The films ranking in the list.
        static List<string> l_film = new List<string>(); // The name of the film.
        static List<string> l_origin = new List<string>(); // The country of origin for the film.
        static List<string> l_weekend_gross = new List<string>(); // The weekend gross of the film.
        static List<string> l_distributor = new List<string>(); // The distributor of the film.
        static List<string> l_change = new List<string>(); // The percentage of change in the last week.
        static List<string> l_weeks_on_release = new List<string>(); // The weeks since the release of the film.
        static List<string> l_cinemas = new List<string>(); // The number of cinemas which showed the film.
        static List<string> l_site_average = new List<string>(); // The average of money earned per site.
        static List<string> l_total_gross = new List<string>(); // The total gross to date.

        // Calculate the average of "weekend gross" for all top 15 films.
        static void Top_15(List<string> rank, List<string> gross)
        {
            double total = 0;
            
            // Going through every line of the loaded data.
            for (int i = 0; i < rank.Count; i++)
            {
                // If the rank is 1 through 15...
                if (Convert.ToInt32(rank[i]) <= 15)
                {
                    // Add it to the total
                    total += Convert.ToDouble(gross[i]); 
                }
            }

            // All them added up divided by the amount of films.
            Console.WriteLine("The weekend gross of the top 15 films is: £{0}", total / 15);
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
            // Reading in the values of the files manually
            // There are 49 rows that we have to worry about
            // (ones in top 15, and ones with UK or USA in them)
            for (int i = 0; i < 49; i++)
            {
                Console.Write("What is the rank of the film? ");
                string rank = Console.ReadLine();
                l_rank.Add(rank);

                Console.Write("What is the name of the film? ");
                string name = Console.ReadLine();
                l_film.Add(name);

                Console.Write("What is the country of origin? ");
                string origin = Console.ReadLine();
                l_origin.Add(origin);

                Console.Write("What is the weekend gross? (No £ or ,) ");
                string weekend_gross = Console.ReadLine();
                l_weekend_gross.Add(weekend_gross);

                Console.Write("Who is the distributor? ");
                string distributor = Console.ReadLine();
                l_distributor.Add(distributor);

                Console.Write("What is the percentage of change in the last week? ");
                string change = Console.ReadLine();
                l_change.Add(change);

                Console.Write("How many weeks was in on release? ");
                string weeks_on_release = Console.ReadLine();
                l_weeks_on_release.Add(weeks_on_release);

                Console.Write("How many cinemas was it shown in? ");
                string cinemas = Console.ReadLine();
                l_cinemas.Add(cinemas);

                Console.Write("How much was earned on average at each site? ");
                string site_average = Console.ReadLine();
                l_site_average.Add(site_average);

                Console.Write("What was the total gross? ");
                string total_gross = Console.ReadLine();
                l_total_gross.Add(total_gross);

                Console.WriteLine();
            }
            
            Top_15(l_rank, l_weekend_gross);
            Console.ReadKey();
        }
    }
}

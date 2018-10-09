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
            
            // Going through every line of the loaded csv.
            for (int i = 0; i <= rank.Count(); i++)
            {
                // If the rank is 1 through 15...
                if (Int32.Parse(rank[i]) < 16)
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
            // Reading the XLS file which has been converted into a .csv file
            // I have also removed the headers and extra data we don't need from the given file
            using (var reader = new StreamReader(@"Weekend Box Office.csv"))
            { 
                // Keeps going until there is no more left to read
                while (!reader.EndOfStream)
                {
                    // Takes one line from the .csv file
                    var line = reader.ReadLine();
                    // Splits each value upon the commas in the .csv file
                    var values = line.Split(',');

                    // Each list defined above will take the value which is given
                    l_rank.Add(values[0]);
                    l_film.Add(values[1]);
                    l_origin.Add(values[2]);
                    l_weekend_gross.Add(values[3]);
                    l_distributor.Add(values[4]);
                    l_change.Add(values[5]);
                    l_weeks_on_release.Add(values[6]);
                    l_cinemas.Add(values[7]);
                    l_site_average.Add(values[8]);
                    l_total_gross.Add(values[9]);
                }
                
            }
            
            Top_15(l_rank, l_weekend_gross);
            Console.ReadKey();
        }
    }
}

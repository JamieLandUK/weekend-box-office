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
        static void top_15()
        {
            // Calculate the average of "weekend gross" for all top 15 films.
            Console.WriteLine();
        }

        static void all_UK_USA()
        {
            // Calculates the average ‘weekend gross’ of all UK/USA origin films
            Console.WriteLine();
        }

        static void how_many_viewings()
        {
            // Given an average ticket price of £8.00, how many ‘viewings’ of ‘Disney’s Christopher Robin’ were made in this week? 
            Console.WriteLine();
        }

        static void previous_week()
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
                List<string> l_rank = new List<string>(); // The films ranking in the list.
                List<string> l_film = new List<string>(); // The name of the film.
                List<string> l_origin = new List<string>(); // The country of origin for the film.
                List<string> l_weekend_gross = new List<string>(); // The weekend gross of the film.
                List<string> l_distributor = new List<string>(); // The distributor of the film.
                List<string> l_change = new List<string>(); // The percentage of change in the last week.
                List<string> l_weeks_on_release = new List<string>(); // The weeks since the release of the film.
                List<string> l_cinemas = new List<string>(); // The number of cinemas which showed the film.
                List<string> l_site_average = new List<string>(); // The average of money earned per site.
                List<string> l_total_gross = new List<string>(); // The total gross to date.

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
        }
    }
}

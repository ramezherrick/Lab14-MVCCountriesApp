using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Lab14_MVCContriesApp
{
    class CountryListView
    {
        //Next Create a CountryListView class. This view will take a list of countries in its constructor.It should have the following property and method: 
        //Public List<Country> Countries - store the parameter from the constructor here.
        //Public void Display() - Print the name of each country in the list along with the index for each country

        public List<Country> Countries { get; set; }

        public CountryListView (List<Country> countries)
        {
            this.Countries = countries;
        }
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i} - {Countries[i].Name}");
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_MVCContriesApp
{
    class CountryView
    {
        // Next Create a CountryView Class.In the constructor require a Country be taken in 
        //and set to DisplayCountry.

        //Create the following property and method: 
        //Public Country DisplayCountry
        //Public void Display() - This method will print out the Name, Continent, and Colors of the Country DisplayCountry property
        
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {

            DisplayCountry = country;
        }
        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Continent);
            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                Console.WriteLine(DisplayCountry.Colors[i]);
            }
        }

    }
}


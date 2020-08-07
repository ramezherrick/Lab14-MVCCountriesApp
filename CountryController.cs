using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_MVCContriesApp
{
    class CountryController
    {

        public List<Country> CountrtDb { get; set; }

        public CountryController()
        {
            CountrtDb = new List<Country>();
            CountrtDb.Add(new Country("USA", "North America", new List<string> { "Red", "White", "Blue" }));
            CountrtDb.Add(new Country("Canada", "North America", new List<string> { "Red", "White"}));
        }

        public void CountryAction(Country C)
        {
            CountryView v = new CountryView(C);
            v.Display();
        }


        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountrtDb);
            string cont = "y";
            while (cont == "y")
            {

                Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list:");
                clv.Display();

                int index = int.Parse(Console.ReadLine());

                CountryAction(CountrtDb[index]);

                Console.Write("Do you want to select another contry (y/n)? ");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y") continue;
                else break;
            }
        }


    }
}

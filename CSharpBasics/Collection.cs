using System;
using System.Collections.Generic;

namespace LearnCOllection{
    public class Collection{
       public void LearnList(){
            List<byte>  ages = new List<byte>();
            ages.Add(1);
             ages.Add(10);
              ages.Add(100); 
              ages.Add(150);
               ages.Add(80);
               List<Country> countries = new List<Country>();
               Country country1 = new Country();
               countries.Add(country1);
        }
      public void LearnDictionary(){
            var countryCapital = new Dictionary<string, string>
            //if i already know the item to be added in dictionary
            {
                ["Nepal"]= "Kathmandu",
                 ["India"]= "Delhi",
                  ["Japan"]= "Tokyo"

            };

// countryCapital.Add("Nepal","Kathmandu");
// countryCapital.Add("India ","New Delhi");
// countryCapital.Add("Japan","Tokiyo");

      foreach(var country in countryCapital){
          Console.WriteLine($"country:{country.Key} country Capital:{country.Value}");
      }
        }
    }
    public class Country{
        public string Name { get; set; }
    }
}
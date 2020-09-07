using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCoreCoffeeApp.Models
{
    public class Drink
    {

        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name}{Price}";
        }

        public void CheckSize(string word)
        {
            if (word.Contains("Small"))
            {
                Price += 1.00m;
            }
            if (word.Contains("Medium"))
            {
                Price += 1.50m;
            }
            if (word.Contains("Large"))
            {
                Price += 2.00m;
            }
            if (word.Contains("XTRA Big Gulp"))
            {
                Price += 3.50m;
            }
            if (word.Contains("Gallon"))
            {
                Price += 10.50m;
            }
        }

        public void CheckCream(string word) 
        {
            if (word != " " && word != null)
            {
                Price += .50m;
            }
        }
        public void CheckSugar(string word)
        {
            if (word != " " && word != null)
            {
                Price += .25m;
            }
        }
        public void CheckWhipped(string word)
        {
            if (word != " " && word != null)
            {
                Price += 1.00m;
            }
        }

    }
}

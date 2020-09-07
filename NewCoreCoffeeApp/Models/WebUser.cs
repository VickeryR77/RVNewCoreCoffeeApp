using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCoreCoffeeApp.Models
{
    public class WebUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string MusicPreference { get; set; }
        public string RoastPreference { get; set; }
        public string Password { get; set; }
        public string StreetAddress { get; set; }
        public string Time { get; set; }

        public static List<Drink> Cart = new List<Drink>();

    }
}

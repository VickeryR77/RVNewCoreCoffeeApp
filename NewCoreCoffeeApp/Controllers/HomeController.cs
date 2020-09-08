using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewCoreCoffeeApp.Models;
using System.Text.RegularExpressions;


namespace NewCoreCoffeeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpGet] //Initial pull from web populates the form with blank, black font.
        public IActionResult Register()
        {
            ViewData["firstname"] = ""; //Blank

            ViewData["lastname"] = ""; //Blank

            ViewData["email"] = ""; //Blank

            ViewData["password"] = ""; //Blank

            ViewData["firstnamecolor"] = "#000000"; //Black

            ViewData["lastnamecolor"] = "#000000"; //Black

            ViewData["emailcolor"] = "#000000"; //Black

            ViewData["passcolor"] = "#000000"; //Black


            return View();
        }

        [HttpPost]
        public IActionResult Register(string firstname, string lastname, string email, string password, string currentstate, string roastpreference, string musicpreference)
        {
            bool isValidFirstName = !(firstname is null) && firstname != ""; //Is Valid if firstname is not null or blank.

            bool isValidLastName = !(lastname is null) && lastname != ""; //Is Valid if lastname is not null or blank.

            bool isValidEmail = !(email is null) && email != "" && email.Contains("@"); //Email Regex Reqs.

            bool isValidPassword = !(password is null) && password != "" && Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$"); //Password Regex Reqs.

            if (isValidFirstName && isValidLastName && isValidEmail && isValidPassword) //If ALL checks out...
            {
                WebUser user = new WebUser() //Create a new webuser with the information
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    State = currentstate,
                    RoastPreference = roastpreference,
                    MusicPreference = musicpreference,
                    Password = password,
                    Time = "",
                    StreetAddress = ""
                };

                return View("RegistrationComplete", user); //Finish registering with the user information.
            }

            //ELSE
            //Keep stored information for these variables, excepting password which has autofill turned off for security purposes.

            ViewData["firstname"] = firstname;

            ViewData["lastname"] = lastname;

            ViewData["email"] = email;

            ViewData["pass"] = password;

            ViewData["firstnamecolor"] = isValidFirstName ? "#35DF86" : "#DF3547"; //Border colors are determined by Validity, if false then view the posted

            ViewData["lastnamecolor"] = isValidLastName ? "#35DF86" : "#DF3547";

            ViewData["emailcolor"] = isValidEmail ? "#35DF86" : "#DF3547";

            ViewData["passcolor"] = isValidPassword ? "#35DF86" : "#DF3547";

            return View();
        }


        public IActionResult RegistrationComplete(WebUser user)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Menu(WebUser user)
        {
            WebUser.Cart.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult Menu(string size, string roastpreference, string beanorigin, string extra1, string extra2, string extra3, WebUser user)
        {

            Drink drink = new Drink()
            {
                Name = $"{size} {roastpreference} roast from {beanorigin} | Extras: {extra1} {extra2} {extra3}| $",
                Price = 0.00m
            };

            drink.CheckSize(size);
            drink.CheckCream(extra1);
            drink.CheckSugar(extra2);
            drink.CheckWhipped(extra3);

            WebUser.Cart.Add(drink);

                return View("Menu", user);
        }

        [HttpPost]
        public IActionResult DeliveryReceipt()
        {
            return View();
        }

        public IActionResult PickUpReceipt()
        {
            return View();
        }


        public IActionResult ThankYou1(WebUser user, string Time)
        {
            user.Time = Time;
            return View(user);
        }
        
        public IActionResult ThankYou2(WebUser user, string Address)
        {
            user.StreetAddress = Address;
            return View(user);
        }

    }
}


/*
      Create an additional page for ordering coffee that is linked on summary page after registration
    - This page should have a form that includes:
    - Drink selection
    - Drink size
    - Delivery or pickup
    - If pickup, allow user to select a valid time
    - If delivery, prompt for address and give an estimation on summary after submission
    - Submission
 */

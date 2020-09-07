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
            bool validFirstName = (!(firstname is null) && firstname != ""); //Is Valid if firstname is not null or blank.

            bool validLastName = (!(lastname is null) && lastname != ""); //Is Valid if lastname is not null or blank.

            bool validEmail = (!(email is null) && email != "" && Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$")); //Email Regex Reqs.

            bool validPassword = (!(password is null) && password != "" && Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$")); //Password Regex Reqs.

            if (validFirstName && validLastName && validEmail && validPassword) //If ALL checks out...
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
                };

                return View("RegistrationComplete", user); //Finish registering with the user information.
            }

            //ELSE
            //Keep stored information for these variables, excepting password which has autofill turned off for security purposes.

            ViewData["firstname"] = firstname;

            ViewData["lastname"] = lastname;

            ViewData["email"] = email;

            ViewData["pass"] = password;

            ViewData["firstnamecolor"] = validFirstName ? "#20FF20" : "#FF2020"; //Border colors are determined by Validity, if false then view the posted

            ViewData["lastnamecolor"] = validLastName ? "#20FF20" : "#FF2020";

            ViewData["emailcolor"] = validEmail ? "#20FF20" : "#FF2020";

            ViewData["passcolor"] = validPassword ? "#20FF20" : "#FF2020";

            return View();
        }

        public IActionResult RegistrationComplete()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Menu(WebUser user)
        {
            WebUser.Cart.Clear();
            return View();
        }

        
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

        [HttpPost]
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

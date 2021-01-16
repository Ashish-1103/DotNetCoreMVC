using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_App
{
    public class HomeController:Controller
    {

        public ViewResult Index()
        {
            // relative path to call different name and path view
            // return View("../../TempView/Ashish");
            return View();

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_Git.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>hello</h1>");
        }

        public void About()
        {
            Response.Write("<h1>about</h1>");
        }

        public void Branch()
        {
            Response.Write("<h1>branch</h1>");
        }

       

    }
}

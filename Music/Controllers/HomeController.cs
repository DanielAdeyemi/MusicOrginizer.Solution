using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Music.Models;

namespace Music.Controllers
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index() 
    {
      return View();
    }
  }
}
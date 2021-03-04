using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Music.Models;

namespace Music.Controllers
{
  public class CollectionsController : Controller
  {
    [HttpGet("/collections")]
    public ActionResult Index()
    {
      return View();
    }
    
    [HttpGet("/collections/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/collections")] 
    public ActionResult Create(string collectionType, string collectionArtist)
    {
      Collection newCollection  = new Collection(collectionType, collectionArtist);
      return RedirectToAction("Index");

    }
  }
}
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
      List<Collection> allCollections = Collection.GetAll();
      return View(allCollections);
    }
    
    [HttpGet("/collections/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/collections/new")] 
    public ActionResult Create(string collectionType, string collectionArtist)
    {
      Collection newCollection  = new Collection(collectionType, collectionArtist);
      return RedirectToAction("Index", newCollection);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Music.Models;

namespace Music.Tests
{
  [TestClass]
  public class CollectionTest : IDisposable
  {
    public void Dispose()
    {
      Collection.ClearAll();
    }

    [TestMethod]
    public void CreateCollection_ShowArtistName_Abba()
    {
			Collection newCollection = new Collection("vinyl", "BABA");
			Assert.AreEqual("ABBA", newCollection.Artist);
    }
  }
}

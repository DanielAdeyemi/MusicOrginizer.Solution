using System.Collections.Generic;

namespace Music.Models
{
  public class Collection
  {
    private static List<Collection> _instances = new List<Collection> {};
    public string Type { get; set; }
    public int Id { get; }
    public string Artist { get; set; }
    public Collection(string collectionType, string collectionArtist)
    {
      Type = collectionType;
      Artist = collectionArtist;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Collection> GetAll()
    {
      return _instances;
    }
  }
}
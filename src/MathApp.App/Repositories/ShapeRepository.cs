using MathApp.App.Domain;
using MathApp.App.JsonConverters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MathApp.App.Repositories
{
  public class ShapeRepository
  {
    private static string OUTPUT_PATH = "output.json";

    public void Save(List<Shape> shapes)
    {
      var content = JsonConvert.SerializeObject(shapes, Formatting.Indented);
      File.WriteAllText(OUTPUT_PATH, content);
    }

    public List<Shape> LoadFromDisk()
    {
      if (!File.Exists(OUTPUT_PATH)) return new List<Shape>();

      var content = File.ReadAllText(OUTPUT_PATH);
      return JsonConvert.DeserializeObject<List<Shape>>(content, new JsonSerializerSettings
      {
        Converters = new[] { new ShapeConverter() }
      });
    }
  }
}

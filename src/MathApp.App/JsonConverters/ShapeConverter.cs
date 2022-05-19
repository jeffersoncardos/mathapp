using MathApp.App.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace MathApp.App.JsonConverters
{
  public class ShapeConverter : JsonConverter
  {
    public override bool CanConvert(Type objectType)
    {
      return objectType == typeof(Shape);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
      var jo = JObject.Load(reader);
      var objectName = jo["Name"].Value<string>();

      var shape = objectName switch
      {
        nameof(Circle) => jo.ToObject<Circle>(serializer),
        // triangles
        nameof(Equilateral) => jo.ToObject<Equilateral>(serializer),
        nameof(Isoceles) => jo.ToObject<Isoceles>(serializer),
        nameof(Scalene) => jo.ToObject<Scalene>(serializer),
        // quadrilaterals
        nameof(Square) => jo.ToObject<Square>(serializer),
        nameof(Rectangle) => jo.ToObject<Scalene>(serializer),
        _ => default(Shape)
      };

      return shape;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      throw new NotImplementedException();
    }
  }
}

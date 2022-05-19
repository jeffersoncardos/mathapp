using MathApp.App.Domain;
using MathApp.App.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MathApp.App.Services
{
  public class ShapeService
  {
    private ShapeRepository _repository;

    public static List<Shape> _shapes = new List<Shape>();

    public ShapeService()
    {
      _repository = new ShapeRepository();
    }

    public List<string> GetAvailableShapes()
    {
      return typeof(Shape).Assembly.GetTypes()
        .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(Shape)))
        .Select(type => type.Name)
        .ToList();
    }

    public void Save()
    {
      _repository.Save(_shapes);
    }

    public void Add(Shape shape)
    {
      _shapes.Add(shape);
    }

    public IReadOnlyList<Shape> GetAll()
    {
      return _shapes.AsReadOnly();
    }

    public void LoadFromDisk()
    {
      _shapes = _repository.LoadFromDisk();
    }

    public Dictionary<string, int> GetGroups()
    {
      return _shapes
        .OrderBy(shape => shape.Name)
        .GroupBy(shape => shape.Name)
        .ToDictionary(shape => shape.Key, shape => shape.Count());
    }
  }
}

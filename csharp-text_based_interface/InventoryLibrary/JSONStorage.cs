using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class JSONStorage
{
    private Dictionary<string, object> objects = new Dictionary<string, object>();
    private string filePath = Path.Combine("storage", "inventory_manager.json");

    public Dictionary<string, object> All()
    {
        return objects;
    }

    public void New(object obj)
    {
        string key = $"{obj.GetType().Name}.{obj.GetHashCode()}";
        objects[key] = obj;
    }

    public void Save()
    {
        string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public void Load()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            objects = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
        }
    }
}

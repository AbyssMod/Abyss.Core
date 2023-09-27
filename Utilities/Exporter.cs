using System;
using System.IO;
using System.Text;
using FullSerializer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Abyss.Utilities;

/// <summary>
/// Allows you to export game data to json files
/// </summary>
public static class Exporter
{
    private static readonly fsSerializer Serializer = new();

    /// <summary>
    /// Exports the given object to the given path using <see cref="JsonUtility.ToJson(object)"/>, and removing the serializationData field
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="path"></param>
    /// <param name="throwForNullObj"></param>
    /// <typeparam name="T"></typeparam>
    public static void Export<T>(T? obj, string path, bool throwForNullObj = true)
    {
        if (obj == null)
        {
            if (throwForNullObj)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            return;
        }

        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentException("Value cannot be null or empty.", nameof(path));
        }

        if(!Directory.Exists(Path.GetDirectoryName(path)))
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);

        Serializer.TrySerialize(typeof(T), obj, out var data).AssertSuccessWithoutWarnings();

        // emit the data via JSON
        var jsonString = fsJsonPrinter.CompressedJson(data);

        JObject jsonObj = (JObject)JsonConvert.DeserializeObject(jsonString)!;

        jsonObj.Remove("serializationData");

        jsonString = jsonObj.ToString(Formatting.Indented);

        File.WriteAllText(path, jsonString);
    }
}
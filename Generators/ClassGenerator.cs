using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FluffyUnderware.DevTools.Extensions;
using FullSerializer;
using HarmonyLib;
using UnityEngine;

namespace Abyss.Generators;

internal static class ClassGenerator
{
    //generate a c# class source file (with already filled-in values) from a scriptableobject
    private static string Generate<T>(T obj, string @namespace) where T : ScriptableObject
    {
        var type = typeof(T);

        var sb = new StringBuilder();

        sb.AppendLine($"namespace {@namespace};");

        sb.AppendLine($"public static class {obj.name}");

        sb.AppendLine("{");

        foreach (var field in AccessTools.GetDeclaredFields(type))
        {
            string value = string.Empty;

            if(IsNumericType(field.FieldType) || field.FieldType.IsPrimitive)
            {
                value = field.GetValue(obj).ToString().ToLowerInvariant();
                if (field.FieldType == typeof(float))
                    value += "f";
            }
            else if (field.FieldType.IsEnum)
            {
                value = field.FieldType.FullName + "." + field.GetValue(obj);
            }

            if(field.FieldType == typeof(string))
                value = $"\"{value}\"";

            if (field.FieldType == typeof(Vector3))
            {
                var vector3 = (Vector3)field.GetValue(obj);
                value = $"new UnityEngine.Vector3({vector3.x}f, {vector3.y}f, {vector3.z}f)";
            }

            if (field.FieldType.IsClass && field.FieldType != typeof(string))
            {
                typeof(ScriptableObjectInstances).GetProperties().ForEach(p =>
                {
                    if (p.PropertyType == typeof(IReadOnlyCollection<T>))
                    {
                        value =
                            $"System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.{p.Name}, x => x.name == \"{obj.name}\").{field.Name}"; //todo: optimize this to not use linq
                    }
                });
            }


            sb.AppendLine($"    public static {field.FieldType.CSharpName(true)} {field.Name} = {value};");
        }

        sb.AppendLine("}");

        return sb.ToString();
    }

    private static readonly HashSet<Type> NumericTypes = new()
    {
        typeof(int),
        typeof(uint),
        typeof(double),
        typeof(decimal),
        typeof(float),
        typeof(long),
        typeof(ulong),
        typeof(short),
        typeof(ushort),
        typeof(byte),
        typeof(sbyte),
    };

    private static bool IsNumericType(Type type)
    {
        return NumericTypes.Contains(type) || NumericTypes.Contains(Nullable.GetUnderlyingType(type));
    }

    internal static void Export<T>(T obj) where T : ScriptableObject
    {
        var dir = @"C:\Users\gjguz\source\repos\Dredge\Abyss\Abyss.Core\GameReferences\" + typeof(T).Name + "s";
        Directory.CreateDirectory(dir);
        File.WriteAllText(Path.Combine(dir, $"{obj.name}.cs"), Generate(obj, "Abyss.GameReferences." + typeof(T).Name + "s"));
    }
}
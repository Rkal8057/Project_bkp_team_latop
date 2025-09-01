using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DB.Login;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

public static class DatabaseSeeder
{
    public static void SeedData<T>(loginDBContext context, string jsonFilePath) where T : class, new()
    {
        // Read data from JSON file
        var jsonData = File.ReadAllText(jsonFilePath);
        var newData = JsonConvert.DeserializeObject<List<T>>(jsonData);

        // Retrieve existing data from the database
        var dbSet = context.Set<T>();
        var existingData = dbSet.ToList();

        // Perform left join to find records not in the database
        var dataToAdd = newData.Except(existingData, new GenericComparer<T>("id"));

        // Add missing data to the database
        dbSet.AddRange(dataToAdd);
        context.SaveChanges();
    }
}

public class GenericComparer<T> : IEqualityComparer<T>
{
    private readonly string _keyPropertyName;

    public GenericComparer(string keyPropertyName)
    {
        _keyPropertyName = keyPropertyName;
    }

    public bool Equals(T x, T y)
    {
        if (x == null || y == null) return false;

        var type = typeof(T);
        var keyProperty = type.GetProperty(_keyPropertyName);

        if (keyProperty == null) throw new ArgumentException($"Property '{_keyPropertyName}' not found on type '{type.Name}'.");

        var xValue = keyProperty.GetValue(x);
        var yValue = keyProperty.GetValue(y);

        return xValue != null && xValue.Equals(yValue);
    }

    public int GetHashCode(T obj)
    {
        var type = typeof(T);
        var keyProperty = type.GetProperty(_keyPropertyName);

        if (keyProperty == null) throw new ArgumentException($"Property '{_keyPropertyName}' not found on type '{type.Name}'.");

        var keyValue = keyProperty.GetValue(obj);

        return keyValue != null ? keyValue.GetHashCode() : 0;
    }
}
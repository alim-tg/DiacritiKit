using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit;

public static class ProvidersLoader
{
    public static IDictionary<string, IDiacriticProvider> LoadLocaleSpecificProviders()
    {
        var type = typeof(IDiacriticProvider);
        return Assembly.GetExecutingAssembly().GetTypes()
            .Where(x => x.GetInterfaces().Contains(type))
            .Select(x => (IDiacriticProvider)Activator.CreateInstance(x))
            .ToDictionary(x => x.Locale);
    }
}
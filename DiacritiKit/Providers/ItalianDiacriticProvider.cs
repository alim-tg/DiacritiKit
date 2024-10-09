using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class ItalianDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "it-IT";
    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { '&', "e" }
    };
}
using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class DutchDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "nl-NL";
    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { '&', "en" }
    };
}
using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class NorwegianDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "no-NO";
    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { '&', "og" },
        { 'Å', "AA" },
        { 'Æ', "AE" },
        { 'Ø', "OE" },
        { 'å', "aa" },
        { 'æ', "ae" },
        { 'ø', "oe" }
    };

}
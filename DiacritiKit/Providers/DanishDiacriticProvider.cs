using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class DanishDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "da-DK";
    
    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { 'Ø', "OE" },
        { 'ø', "oe" },
        { 'Å', "AA" },
        { 'å', "aa" },
        { '%', "procent" },
        { '&', "og" },
        { '|', "eller" },
        { '$', "dollar" },
        { '<', "mindre end" },
        { '>', "større end" }
    };
}
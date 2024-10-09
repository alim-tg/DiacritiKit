using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class SwedishDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "sv-SE";
    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { '&', "och" },
        { 'Å', "AA" },
        { 'Ä', "AE" },
        { 'Ö', "OE" },
        { 'å', "aa" },
        { 'ä', "ae" },
        { 'ö', "oe" }
    };
}
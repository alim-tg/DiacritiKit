using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class PortugueseDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "pt-BR";
    
    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { '%', "porcento" },
        { '&', "e" },
        { '<', "menor" },
        { '>', "maior" },
        { '|', "ou" },
        { '¢', "centavo" },
        { '∑', "soma" },
        { '£', "libra" },
        { '∞', "infinito" },
        { '♥', "amor" }
    };

}
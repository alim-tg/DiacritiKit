using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class BulgarianDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "bg-BG";

    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { '%', "por ciento" },
        { '&', "y" },
        { '<', "menor que" },
        { '>', "mayor que" },
        { '|', "o" },
        { '¢', "centavos" },
        { '£', "libras" },
        { '¤', "moneda" },
        { '₣', "francos" },
        { '∑', "suma" },
        { '∞', "infinito" },
        { '♥', "amor" }
    };
}
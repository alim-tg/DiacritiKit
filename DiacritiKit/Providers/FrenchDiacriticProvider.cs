using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class FrenchDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "fr-FR";

    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { '%', "pourcent" },
        { '&', "et" },
        { '<', "plus petit" },
        { '>', "plus grand" },
        { '|', "ou" },
        { '¢', "centime" },
        { '£', "livre" },
        { '¤', "devise" },
        { '₣', "franc" },
        { '∑', "somme" },
        { '∞', "infini" },
        { '♥', "amour" }
    };
}
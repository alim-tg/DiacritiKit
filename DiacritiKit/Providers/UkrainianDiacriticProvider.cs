using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class UkrainianDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "uk-UA";
    
    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { 'И', "Y" },
        { 'и', "y" },
        { 'Й', "Y" },
        { 'й', "y" },
        { 'Ц', "Ts" },
        { 'ц', "ts" },
        { 'Х', "Kh" },
        { 'х', "kh" },
        { 'Щ', "Shch" },
        { 'щ', "shch" },
        { 'Г', "H" },
        { 'г', "h" }
    };
}
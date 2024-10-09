using System;
using System.Collections.Generic;
using System.Text;
using DiacritiKit.Providers;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit;

public static class StringExtensions
{
    private static readonly Lazy<ICommonDiacriticProvider> CommonDiacriticImpl = new(() => new CommonDiacriticProvider());
    private static readonly Lazy<IDictionary<string, IDiacriticProvider>> LocaleSpecificDiacriticImpl =
        new(ProvidersLoader.LoadLocaleSpecificProviders);
    
    private static ICommonDiacriticProvider CommonDiacriticProvider => CommonDiacriticImpl.Value;
    private static IDictionary<string, IDiacriticProvider> LocaleSpecificDiacritics =>
        LocaleSpecificDiacriticImpl.Value;
    

    public static string ReplaceDiacritics(this string input, DiacriticOptions opts = null) =>
        opts is null ? ReplaceNonLocaleSpecificDiacritics(input) : ReplaceLocaleSpecificDiacritics(input, opts.Locale);
  
    private static string ReplaceLocaleSpecificDiacritics(string input, string locale)
    {
        var sb = new StringBuilder();
        if (!LocaleSpecificDiacritics.TryGetValue(locale, out var localeSpecificDiacritic))
        {
            return ReplaceNonLocaleSpecificDiacritics(input);
        }
        
        foreach (var el in input)
        {
            if (localeSpecificDiacritic.Provide.TryGetValue(el, out var localeSpecificCharacter))
            {
                sb.Append(localeSpecificCharacter);
                continue;
            }
            
            sb.Append(CommonDiacriticProvider.Provide.TryGetValue(el, out var converted) ? converted : el);
        }

        return sb.ToString();
    }
    

    private static string ReplaceNonLocaleSpecificDiacritics(string input)
    {
        var sb = new StringBuilder();
        foreach (var el in input)
        {
            sb.Append(CommonDiacriticProvider.Provide.TryGetValue(el, out var converted) ? converted : el);
        }

        return sb.ToString();
    }
}
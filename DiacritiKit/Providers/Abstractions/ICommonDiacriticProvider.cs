using System.Collections.Generic;

namespace DiacritiKit.Providers.Abstractions;

public interface ICommonDiacriticProvider
{
    public IReadOnlyDictionary<char, string> Provide { get; }
}
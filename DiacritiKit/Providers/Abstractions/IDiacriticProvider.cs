namespace DiacritiKit.Providers.Abstractions;

public interface IDiacriticProvider : ICommonDiacriticProvider
{
    public string Locale { get; }
}
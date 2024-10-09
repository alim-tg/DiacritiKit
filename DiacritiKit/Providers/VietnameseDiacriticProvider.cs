using System.Collections.Generic;
using DiacritiKit.Providers.Abstractions;

namespace DiacritiKit.Providers;

public class VietnameseDiacriticProvider : IDiacriticProvider
{
    public string Locale { get; } = "vi-VN";
    public IReadOnlyDictionary<char, string> Provide { get; } = new Dictionary<char, string>
    {
        { 'Đ', "D" },
        { 'đ', "d" }
    };
}
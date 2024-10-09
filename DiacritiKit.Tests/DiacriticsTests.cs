using Xunit;

namespace DiacritiKit.Tests;

public class DiacriticsTests
{
    [Theory]
    [InlineData("L'univers est vaste, mais nous ne comprenons qu'une infime partie de ses mystères.", "fr-FR", "L'univers est vaste, mais nous ne comprenons qu'une infime partie de ses mysteres.")]
    [InlineData("À l'école, ils étudient l'évolution des civilisations et l'importance de l'éducation dans chaque société.", "fr-FR", "A l'ecole, ils etudient l'evolution des civilisations et l'importance de l'education dans chaque societe.")]
    public void Replace_Diacritics_French_Success(string input, string locale, string expected)
    {
        var converted = input.ReplaceDiacritics(new DiacriticOptions(locale));
        Assert.Equal(converted, expected);
    }
    
    [Theory]
    [InlineData("Übermäßiger Ärger führt häufig zu Missverständnissen, besonders während der öffentlichen Diskussionen.", "de-DE", "Ubermassiger Arger fuhrt haufig zu Missverstandnissen, besonders wahrend der offentlichen Diskussionen.")]
    [InlineData("Die Ökologie spielt eine wesentliche Rolle in der globalen Erwärmung, insbesondere in den nördlichen Ländern.", "de-DE", "Die Okologie spielt eine wesentliche Rolle in der globalen Erwarmung, insbesondere in den nordlichen Landern.")]
    public void Replace_Diacritics_German_Success(string input, string locale, string expected)
    {
        var converted = input.ReplaceDiacritics(new DiacriticOptions(locale));
        Assert.Equal(converted, expected);
    }
    
    [Theory]
    [InlineData("El árbol en el jardín es más alto que el edificio y está lleno de pájaros cantando.", "es-MX", "El arbol en el jardin es mas alto que el edificio y esta lleno de pajaros cantando.")]
    [InlineData("Mi canción favorita tiene una melodía única y letras que tocan el corazón.", "es-ES", "Mi cancion favorita tiene una melodia unica y letras que tocan el corazon.")]
    public void Replace_Diacritics_Spain_Success(string input, string locale, string expected)
    {
        var converted = input.ReplaceDiacritics(new DiacriticOptions(locale));
        Assert.Equal(converted, expected);
    }
    
    [Theory]
    [InlineData("La pizza margherita è deliziosa e rappresenta la tradizione culinaria italiana.", "it-IT", "La pizza margherita e deliziosa e rappresenta la tradizione culinaria italiana.")]
    [InlineData("L'arte e la cultura sono fondamentali per la nostra identità.", "it-IT", "L'arte e la cultura sono fondamentali per la nostra identita.")]
    [InlineData("Il sole splende nel cielo blu e le nuvole sono bianche.", "it-IT", "Il sole splende nel cielo blu e le nuvole sono bianche.")]
    [InlineData("Andiamo al mercato per comprare frutta fresca e verdura.", "it-IT", "Andiamo al mercato per comprare frutta fresca e verdura.")]
    [InlineData("La musica italiana è famosa in tutto il mondo.", "it-IT", "La musica italiana e famosa in tutto il mondo.")]
    [InlineData("I bambini giocano felici nel parco durante la primavera.", "it-IT", "I bambini giocano felici nel parco durante la primavera.")]
    public void Replace_Diacritics_Italian_Success(string input, string locale, string expected)
    {
        var converted = input.ReplaceDiacritics(new DiacriticOptions(locale));
        Assert.Equal(converted, expected);
    }
        
    [Theory]
    [InlineData("Вот как то так", "ru-RU", "Vot kak to tak")]
    [InlineData("Шли мимо леса, искали хорошие решения", "ru-RU", "Shli mimo lesa, iskali horoshie resheniya")]
    public void Replace_Diacritics_Russian_Success(string input, string locale, string expected)
    {
        var converted = input.ReplaceDiacritics(new DiacriticOptions(locale));
        Assert.Equal(converted, expected);
    }
}
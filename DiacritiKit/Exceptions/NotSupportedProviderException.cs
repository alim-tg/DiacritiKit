using System;

namespace DiacritiKit.Exceptions;

public class NotSupportedProviderException(string message) 
    : Exception(message + " Provide a custom impl by inheriting from interface DiacritiKit.Providers.Abstractions.IDiacriticProvider ");
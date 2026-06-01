using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace AvmB2B.Api.Helpers;

public static class B2BCredentialGenerator
{
    public static string GenerateUsername(string? unvan, string? ad, string? soyad)
    {
        var firstName = GetFirstName(unvan, ad);

        var username = Normalize(firstName);

        if (string.IsNullOrWhiteSpace(username))
            username = "USER";

        return username;
    }

    public static string GeneratePassword(string? unvan, string? ad, string? soyad, string cariKod)
    {
        var firstName = GetFirstName(unvan, ad);
        var lastName = GetLastName(unvan, soyad);

        var normalizedFirstName = Normalize(firstName);
        var normalizedLastName = Normalize(lastName);

        var passwordNamePart = $"{normalizedFirstName}{normalizedLastName}";

        if (string.IsNullOrWhiteSpace(passwordNamePart))
            passwordNamePart = "USER";

        var numberPart = cariKod?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(numberPart))
            numberPart = "00000";

        return $"{passwordNamePart}{numberPart}";
    }

    private static string GetFirstName(string? unvan, string? ad)
    {
        if (!string.IsNullOrWhiteSpace(ad))
            return ad.Trim();

        if (string.IsNullOrWhiteSpace(unvan))
            return "USER";

        var words = unvan.Trim()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        return words.Length > 0 ? words[0] : "USER";
    }

    private static string GetLastName(string? unvan, string? soyad)
    {
        if (!string.IsNullOrWhiteSpace(soyad))
            return soyad.Trim();

        if (string.IsNullOrWhiteSpace(unvan))
            return "";

        var words = unvan.Trim()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words.Length < 2)
            return "";

        return words[1];
    }

    private static string Normalize(string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return "";

        text = text.Trim().ToUpperInvariant();

        text = text
            .Replace("İ", "I")
            .Replace("İ", "I")
            .Replace("Ğ", "G")
            .Replace("Ü", "U")
            .Replace("Ş", "S")
            .Replace("Ö", "O")
            .Replace("Ç", "C");

        var normalized = text.Normalize(NormalizationForm.FormD);
        var builder = new StringBuilder();

        foreach (var ch in normalized)
        {
            var category = CharUnicodeInfo.GetUnicodeCategory(ch);

            if (category != UnicodeCategory.NonSpacingMark)
                builder.Append(ch);
        }

        var cleaned = builder.ToString().Normalize(NormalizationForm.FormC);

        cleaned = Regex.Replace(cleaned, @"[^A-Z0-9]", "");

        return cleaned.Trim();
    }
}
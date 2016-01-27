/// <summary>
/// Extension for string class in .NET .
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Hashes string using md5 and than converts the hashed string to Unicode.
    /// </summary>
    /// <param name="input">The input string to be hashed</param>
    /// <returns>Hashed string</returns>
    public static string ToMd5Hash(this string input)
    {
        var md5Hash = MD5.Create();
        var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        var builder = new StringBuilder();

        for (int i = 0; i < data.Length; i++)
        {
            builder.Append(data[i].ToString("x2"));
        }

        return builder.ToString();
    }
    /// <summary>
    /// Checks if the string is predefined Boolean value.
    /// </summary>
    /// <param name="input">String to be checked.</param>
    /// <returns>True or False.</returns>
    public static bool ToBoolean(this string input)
    {
        var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
        return stringTrueValues.Contains(input.ToLower());
    }

    /// <summary>
    /// Convert the input string into 16 bit intiger / short if possible.
    /// </summary>
    /// <param name="input">String to be converted.</param>
    /// <returns>Short version of the string or 0.</returns>
    public static short ToShort(this string input)
    {
        short shortValue;
        short.TryParse(input, out shortValue);
        return shortValue;
    }

    /// <summary>
    /// Convert the input string into 32 bit integer if possible.
    /// </summary>
    /// <param name="input">String to be converted.</param>
    /// <returns>Integer version of the string or 0.</returns>
    public static int ToInteger(this string input)
    {
        int integerValue;
        int.TryParse(input, out integerValue);
        return integerValue;
    }

    /// <summary>
    /// Convert the input string into 64 bit intiger / long if possible.
    /// </summary>
    /// <param name="input">String to be converted.</param>
    /// <returns>Long version of the string or 0.</returns>
    public static long ToLong(this string input)
    {
        long longValue;
        long.TryParse(input, out longValue);
        return longValue;
    }
    /// <summary>
    /// Convert the input string into DateTime if possible
    /// </summary>
    /// <param name="input">String to be converted.</param>
    /// <returns>DateTime version of the string or 0.</returns>
    public static DateTime ToDateTime(this string input)
    {
        DateTime dateTimeValue;
        DateTime.TryParse(input, out dateTimeValue);
        return dateTimeValue;
    }
    /// <summary>
    /// Capitalize the first letter of the given string.
    /// </summary>
    /// <param name="input">String to be converted.</param>
    /// <returns>The same strign with the first letter capitalized.</returns>
    public static string CapitalizeFirstLetter(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        return
            input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) +
            input.Substring(1, input.Length - 1);
    }
    /// <summary>
    /// To fing the substring with given 
    /// starting string and ending string.
    /// </summary>
    /// <param name="input">String text.</param>
    /// <param name="startString">Starting string.</param>
    /// <param name="endString">Ending string.</param>
    /// <param name="startFrom">The starting position 
    /// of the substring we want.</param>
    /// <returns>Substring from starting to ending string.</returns>
    public static string GetStringBetween(
        this string input, string startString, string endString, int startFrom = 0)
    {
        input = input.Substring(startFrom);
        startFrom = 0;
        if (!input.Contains(startString) || !input.Contains(endString))
        {
            return string.Empty;
        }

        var startPosition =
            input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
        if (startPosition == -1)
        {
            return string.Empty;
        }

        var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
        if (endPosition == -1)
        {
            return string.Empty;
        }

        return input.Substring(startPosition, endPosition - startPosition);
    }
    /// <summary>
    /// Convert all Cyrillic letter to 
    /// their equavalent Latin letter.
    /// </summary>
    /// <param name="input">Cyrillic letters string.</param>
    /// <returns>Latin letters string.</returns>
    public static string ConvertCyrillicToLatinLetters(this string input)
    {
        var bulgarianLetters = new[]
        {
            "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
            "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
        };
        var latinRepresentationsOfBulgarianLetters = new[]
        {
            "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
            "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
            "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
        };
        for (var i = 0; i < bulgarianLetters.Length; i++)
        {
            input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
            input = input.Replace(bulgarianLetters[i].ToUpper(),
                latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
        }

        return input;
    }
    /// <summary>
    /// Convert all Latin letter to 
    /// their equavalent Cyrillic letter.
    /// </summary>
    /// <param name="input">Latin letters string.</param>
    /// <returns>Cyrillic letters string.</returns>
    public static string ConvertLatinToCyrillicKeyboard(this string input)
    {
        var latinLetters = new[]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        var bulgarianRepresentationOfLatinKeyboard = new[]
        {
            "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
            "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
            "в", "ь", "ъ", "з"
        };

        for (int i = 0; i < latinLetters.Length; i++)
        {
            input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
            input = input.Replace(latinLetters[i].ToUpper(),
                bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
        }

        return input;
    }
    /// <summary>
    /// Validate the given string 
    /// if is converted right to Cyrillic.
    /// </summary>
    /// <param name="input">String to be validate.</param>
    /// <returns>Validated string with replaced or 
    /// removed Latin letters.</returns>
    public static string ToValidUsername(this string input)
    {
        input = input.ConvertCyrillicToLatinLetters();
        return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
    }
    /// <summary>
    /// Validate the given string with dashes and spaces
    /// if is converted right to Cyrillic.
    /// </summary>
    /// <param name="input">String to be validate.</param>
    /// <returns>Validated string with replaced or 
    /// removed Latin letters.</returns>
    public static string ToValidLatinFileName(this string input)
    {
        input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
        return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
    }
    /// <summary>
    /// Get first letter from given string.
    /// </summary>
    /// <param name="input">The given string.</param>
    /// <param name="charsCount">Total count of characters.</param>
    /// <returns>First character of the string.</returns>
    public static string GetFirstCharacters(this string input, int charsCount)
    {
        return input.Substring(0, Math.Min(input.Length, charsCount));
    }
    /// <summary>
    /// Get the extension of given string.
    /// </summary>
    /// <param name="fileName">File name.</param>
    /// <returns>The extension.</returns>
    public static string GetFileExtension(this string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return string.Empty;
        }

        string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
        if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
        {
            return string.Empty;
        }

        return fileParts.Last().Trim().ToLower();
    }
    /// <summary>
    /// Check if the given string is of certain type.
    /// </summary>
    /// <param name="fileExtension">The file extension.</param>
    /// <returns>The type of the file.</returns>
    public static string ToContentType(this string fileExtension)
    {
        var fileExtensionToContentType = new Dictionary<string, string>
        {
            { "jpg", "image/jpeg" },
            { "jpeg", "image/jpeg" },
            { "png", "image/x-png" },
            { "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
            { "doc", "application/msword" },
            { "pdf", "application/pdf" },
            { "txt", "text/plain" },
            { "rtf", "application/rtf" }
        };
        if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
        {
            return fileExtensionToContentType[fileExtension.Trim()];
        }

        return "application/octet-stream";
    }
    /// <summary>
    /// Convert given string to array of bits.
    /// </summary>
    /// <param name="input">Given string.</param>
    /// <returns>The array of bits.</returns>
    public static byte[] ToByteArray(this string input)
    {
        var bytesArray = new byte[input.Length * sizeof(char)];
        Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
        return bytesArray;
    }
}

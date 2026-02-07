
public static class StringExtension
{
    public static string ToCapitalFirstLetter(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
        
        // Substring(1) : Extract from a specified index to the end

        return (char.ToUpper(str[0]) + str.Substring(1));
    }

    public static string ConcatWith(this string first, string second, string separator) => (first + separator + second);
    
}

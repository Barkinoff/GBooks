

namespace GBooks.Shared.Extensions;

public static class StringExtensions
{
    public static string ToSnakeCase(this string input) 
    {
        if(string.IsNullOrEmpty(input))
            return input;

        var result = "";
        result += char.ToLower(input[0]);

        for(var i = 1; i < input.Length; i++) 
        {
            if (char.IsUpper(input[i])) 
            {
                result += '_';
                result += char.ToLower(input[i]);
                continue;
            }
            result += input[i];
        }
        return result;
    }
}

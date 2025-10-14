using System.Text;

namespace PointsBet;


public class StringFormatter
{
    public static string ToCommaSeparatedList(string[] items, string quote = "")
    {
        if (items == null || items.Length == 0)
            return string.Empty;

        var formattedItems = string.IsNullOrEmpty(quote) ? items 
            : items.Select(x => $"{quote}{x}{quote}");

        return string.Join(", ", formattedItems);
    }
}
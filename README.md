# Points Bet Code Tests

## Problem
Improve a block of code as you see fit in C#.
You may make any improvements you see fit, for example:
- Cleaning up code
- Removing redundancy
- Refactoring / simplifying
- Fixing typos
- Any other light-weight optimisation

```csharp
public class StringFormatter
{
    //Code to improve
    public static string ToCommaSepatatedList(string[] items, string quote)
    {
        StringBuilder qry = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

        if (items.Length > 1)
        {
            for (int i = 1; i < items.Length; i++)
            {
                qry.Append(string.Format(", {0}{1}{0}", quote, items[i]));
            }
        }

        return qry.ToString();
    }
}
```

## Changes Made to improve the code
Link to code: https://github.com/rohanepa/PointsBet/blob/main/PointsBet/StringFormatter.cs
- Method name changed from `ToCommaSepatatedList` to `ToCommaSeparatedList` to fix the typo.
- Use of StringBuilder was replaced with `String.Join` as it is specifically implemented for join operations and optimized for that. StringBuilder is suitable for more complex string formatting operations.
- Set the default value of the quote to be empty string to make it optional when calling the function without a quote.
- `for` loop has been removed and replaced with `IEmunarrable.Select` to make it less code lines and readable. Having said that `for` loop gives more performance if the list has a large number of items.
- String interpolation is used instead of `String.Format` as it is more cleaner and newer way to do it.
- Parameters are validated for nulls and empty lists to return early without performing the operations. This would reduce unexpected exceptions.
- Covered with unit test cases.

## Additional Notes

Exception handling can be done specifically for Out of Memory issues and other unexpected exceptions. But more information needed on how to behave given there is an unexpected exception.
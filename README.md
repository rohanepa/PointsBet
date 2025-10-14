# Points Bet Code Tests

## Changes Made to improve the code

- Method name changed from `ToCommaSepatatedList` to `ToCommaSeparatedList` to fix the typo.
- Use of StringBuilder was replaced with `String.Join` as it is specifically implemented for join operations and optimized for that. StringBuilder is suitable for more complex string formatting operations.
- Set the default value of the quote to be empty string to make it optional when calling the function without a quote.
- `for` loop has been removed and replaced with `iEmunarrable.Select` to make it less code lines and readable. Having said that `for` loop gives more performance if the list has a large number of items.
- Parameters are validated for nulls and empty lists to return early without performing the operations. This would reduce unexpected exceptions.

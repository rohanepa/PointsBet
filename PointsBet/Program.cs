using PointsBet;

var listOfValues = new[] { "Apple", "Orange", "Banana", "Pineapple" };
var outputWithQuotes = StringFormatter.ToCommaSeparatedList(listOfValues, "\"");
var outputWithoutQuotes = StringFormatter.ToCommaSeparatedList(listOfValues);
var outputForNulls = StringFormatter.ToCommaSeparatedList(null);
var outputForEmptyList = StringFormatter.ToCommaSeparatedList([]);
Console.WriteLine($"With quote - {outputWithQuotes}");
Console.WriteLine($"Without quotes - {outputWithoutQuotes}");
Console.WriteLine($"When input value is null - {outputForNulls}");
Console.WriteLine($"When input value is empty - {outputForEmptyList}");
using PointsBet;

var listOfValues = new[] { "Apple", "Orange", "Banana", "Pineapple" };
var output = StringFormatter.ToCommaSeparatedList(listOfValues, "\"");
Console.WriteLine(output);
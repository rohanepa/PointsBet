// See https://aka.ms/new-console-template for more information

using PointsBet;

var listOfValues = new[] { "Apple", "Orange", "Banana", "Pineapple" };
var output = StringFormatter.ToCommaSepatatedList(listOfValues, "\"");
var output2 = StringFormatter.ToCommaSeparatedList(listOfValues, "\"");
Console.WriteLine(output);
Console.WriteLine(output2);
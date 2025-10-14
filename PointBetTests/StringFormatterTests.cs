using FluentAssertions;
using PointsBet;

namespace PointBetTests;

public class StringFormatterTests
{
    [Theory]
    [InlineData("Apple, Orange, Banana, Pineapple","Apple", "Orange", "Banana", "Pineapple")]
    [InlineData("1, 2, 3, 4", "1", "2", "3", "4")]
    [InlineData("", null)]
    [InlineData("")]
    public void ToCommaSeparatedList_ListOfValues_ShouldReturnCommaSeparatedList(string expected, params string[] items)
    {
        //Arrange and Act
        var response = StringFormatter.ToCommaSeparatedList(items);

        //Assert
        response.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData("\"Apple\", \"Orange\", \"Banana\", \"Pineapple\"", "\"",
        "Apple", "Orange", "Banana", "Pineapple")]
    [InlineData("\"1\", \"2\", \"3\", \"4\"", "\"", "1", "2", "3", "4")]
    public void ToCommaSeparatedList_Quote_ShouldReturnTheListFormatterWithQuote(string expected, string quote,
        params string[] items)
    {
        //Arrange and Act
        var response = StringFormatter.ToCommaSeparatedList(items, quote);

        //Assert
        response.Should().BeEquivalentTo(expected);
    }
}
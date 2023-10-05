using OOP_ICT.Models;
using OOP_ICT.Models.Enums;
using Xunit;

namespace OOP_ICT.First.Tests;

public class TestCardFunctions
{
    [Theory]
    [InlineData(CardSuit.Hearts, CardValue.Ace, "\u2661A")]
    [InlineData(CardSuit.Clubs, CardValue.Ace, "\u2663A")]
    [InlineData(CardSuit.Spades, CardValue.Ace, "\u2660A")]
    [InlineData(CardSuit.Diamonds, CardValue.Ace, "\u2662A")]
    public void AreEquals_ToStringInputIsDifferentSuits_ReturnTrue(CardSuit suit, CardValue value, string expected)
    {
        var card = new Card(suit, value);
        Assert.Equal(suit, card.Suit);
        Assert.Equal(value, card.Value);

        Assert.Equal(expected, card.ToString());
    }

    [Theory]
    [InlineData(CardSuit.Hearts, CardValue.Ace, "\u2661A")]
    [InlineData(CardSuit.Hearts, CardValue.King, "\u2661K")]
    [InlineData(CardSuit.Hearts, CardValue.Queen, "\u2661Q")]
    [InlineData(CardSuit.Hearts, CardValue.Jack, "\u2661J")]
    [InlineData(CardSuit.Hearts, CardValue.Ten, "\u266110")]
    [InlineData(CardSuit.Hearts, CardValue.Nine, "\u26619")]
    [InlineData(CardSuit.Hearts, CardValue.Eight, "\u26618")]
    [InlineData(CardSuit.Hearts, CardValue.Seven, "\u26617")]
    [InlineData(CardSuit.Hearts, CardValue.Six, "\u26616")]
    [InlineData(CardSuit.Hearts, CardValue.Five, "\u26615")]
    [InlineData(CardSuit.Hearts, CardValue.Four, "\u26614")]
    [InlineData(CardSuit.Hearts, CardValue.Three, "\u26613")]
    [InlineData(CardSuit.Hearts, CardValue.Two, "\u26612")]
    public void AreEquals_ToStringInputIsDifferentValues_ReturnTrue(CardSuit suit, CardValue value, string expected)
    {
        var card = new Card(suit, value);
        Assert.Equal(suit, card.Suit);
        Assert.Equal(value, card.Value);

        Assert.Equal(expected, card.ToString());
    }
}
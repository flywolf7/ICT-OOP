using OOP_ICT.First.Tests.Util;
using OOP_ICT.Models;
using OOP_ICT.Models.Enums;
using Xunit;

namespace OOP_ICT.First.Tests;

public class TestDeckFunctions
{
    private static readonly string TestFilesRoot = "/AdditionalFiles/Deck/";

    [Fact]
    public void AreEquals_InitialOrderOfTheCards_ReturnTrue()
    {
        var deck = new CardDeck();
        var expectedDeck =
            FileHelper.ReadTextFile(TestFilesRoot + "expected_AreEquals_InitialOrderOfTheCards_ReturnTrue.txt");

        Assert.Equal(expectedDeck, deck.StringDeck());
    }

    [Fact]
    public void InsertCardAtDeck_InsertCardAtBeginning_ReturnTrue()
    {
        var deck = new CardDeck();
        deck.InsertCardAtDeck(0, new Card(CardSuit.Clubs, CardValue.King));
        var expectedDeck =
            FileHelper.ReadTextFile(
                TestFilesRoot + "expected_InsertCardAtDeck_InsertCardAtBeginning_ReturnTrue.txt");

        Assert.Equal(expectedDeck, deck.StringDeck());
    }

    [Fact]
    public void InsertCardAtDeck_InsertCardAtMid_ReturnTrue()
    {
        var deck = new CardDeck();
        deck.InsertCardAtDeck(26, new Card(CardSuit.Clubs, CardValue.King));
        var expectedDeck =
            FileHelper.ReadTextFile(TestFilesRoot + "expected_InsertCardAtDeck_InsertCardAtMid_ReturnTrue.txt");

        Assert.Equal(expectedDeck, deck.StringDeck());
    }

    [Fact]
    public void InsertCardAtDeck_InsertCardAtEnd_ReturnTrue()
    {
        var deck = new CardDeck();
        deck.InsertCardAtDeck(52, new Card(CardSuit.Clubs, CardValue.King));
        var expectedDeck =
            FileHelper.ReadTextFile(TestFilesRoot + "expected_InsertCardAtDeck_InsertCardAtEnd_ReturnTrue.txt");

        Assert.Equal(expectedDeck, deck.StringDeck());
    }


    [Fact]
    public void GetFromCardDeck_GetCardAtBeginning_ReturnTrue()
    {
        var deck = new CardDeck();
        var card = deck.GetCardFromDeck(0);
        var expectedDeck =
            FileHelper.ReadTextFile(TestFilesRoot + "expected_GetFromCardDeck_GetCardAtBeginning_ReturnTrue.txt");

        Assert.Equal(expectedDeck, deck.StringDeck());
        Assert.Equal(new Card(CardSuit.Hearts, CardValue.Ace).ToString(), card.ToString());
    }

    [Fact]
    public void GetFromCardDeck_GetCardAtMid_ReturnTrue()
    {
        var deck = new CardDeck();
        var card = deck.GetCardFromDeck(26);
        var expectedDeck =
            FileHelper.ReadTextFile(TestFilesRoot + "expected_GetFromCardDeck_GetCardAtMid_ReturnTrue.txt");

        Assert.Equal(expectedDeck, deck.StringDeck());
        Assert.Equal(new Card(CardSuit.Spades, CardValue.Eight).ToString(), card.ToString());
    }

    [Fact]
    public void GetFromCardDeck_GetCardAtEnd_ReturnTrue()
    {
        var deck = new CardDeck();
        var card = deck.GetCardFromDeck(51);
        var expectedDeck =
            FileHelper.ReadTextFile(TestFilesRoot + "expected_GetFromCardDeck_GetCardAtEnd_ReturnTrue.txt");

        Assert.Equal(expectedDeck, deck.StringDeck());
        Assert.Equal(new Card(CardSuit.Diamonds, CardValue.Two).ToString(), card.ToString());
    }
}
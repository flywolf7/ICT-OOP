using OOP_ICT.First.Tests.Util;
using OOP_ICT.Models;
using Xunit;

namespace OOP_ICT.First.Tests;

public class TestDealerFunctions
{
    private static readonly string TestFilesRoot = "/AdditionalFiles/Dealer/";

    [Fact]
    public void AreEquals_ShuffleDeck_ReturnTrue()
    {
        var deck = new CardDeck();
        var dealer = new Dealer(deck);
        dealer.Shuffle();
        var expectedDeck =
            FileHelper.ReadTextFile(TestFilesRoot + "expected_AreEquals_ShuffleDeck_ReturnTrue.txt");
        Assert.Equal(expectedDeck, deck.StringDeck());
    }

    [Fact]
    public void AreEquals_DoubleShuffleDeck_ReturnTrue()
    {
        var deck = new CardDeck();
        var dealer = new Dealer(deck);
        dealer.Shuffle();
        dealer.Shuffle();
        var expectedDeck =
            FileHelper.ReadTextFile(TestFilesRoot + "expected_AreEquals_DoubleShuffleDeck_ReturnTrue.txt");

        Assert.Equal(expectedDeck, deck.StringDeck());
    }
}
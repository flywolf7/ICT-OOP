namespace OOP_ICT.Models.Enums;

public enum CardSuit
{
    Hearts,
    Clubs,
    Spades,
    Diamonds,
}

public static class CardSuitExtension
{
    public static string VisibleString(this CardSuit cardSuit)
    {
        return cardSuit switch
        {
            CardSuit.Hearts => "\u2661",
            CardSuit.Clubs => "\u2663",
            CardSuit.Spades => "\u2660",
            CardSuit.Diamonds => "\u2662",
            _ => throw new ArgumentOutOfRangeException(nameof(cardSuit), cardSuit, null)
        };
    }
}
namespace OOP_ICT.Models.Enums;

public enum CardValue
{
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,
    Ace = 14,
}

static class CardValueExtension
{
    public static string VisibleString(this CardValue cardValue)
    {
        return cardValue switch
        {
            CardValue.Two => "2",
            CardValue.Three => "3",
            CardValue.Four => "4",
            CardValue.Five => "5",
            CardValue.Six => "6",
            CardValue.Seven => "7",
            CardValue.Eight => "8",
            CardValue.Nine => "9",
            CardValue.Ten => "10",
            CardValue.Jack => "J",
            CardValue.Queen => "Q",
            CardValue.King => "K",
            CardValue.Ace => "A",
            _ => throw new ArgumentOutOfRangeException(nameof(cardValue), cardValue, null)
        };
    }
}
using OOP_ICT.Models.Enums;

namespace OOP_ICT.Models;

public class Card
{
    private readonly CardSuit _suit;
    private readonly CardValue _value;

    public Card(CardSuit suit, CardValue value)
    {
        _suit = suit;
        _value = value;
    }

    public CardSuit Suit => _suit;

    public CardValue Value => _value;

    public override string ToString()
    {
        return _suit.VisibleString() + _value.VisibleString();
    }
}
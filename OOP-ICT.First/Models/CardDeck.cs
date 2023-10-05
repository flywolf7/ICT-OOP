using OOP_ICT.Models.Enums;

namespace OOP_ICT.Models;

public class CardDeck
{
    private readonly List<Card> _cards = new(52);

    public CardDeck()
    {
        var cardValues = Enum.GetValuesAsUnderlyingType<CardValue>();
        Array.Reverse(cardValues);

        var i = 0;
        foreach (CardValue value in cardValues)
        {
            foreach (CardSuit suit in Enum.GetValuesAsUnderlyingType<CardSuit>())
            {
                var card = new Card(suit, value);
                _cards.Add(card);
            }
        }
    }

    public Card? GetCardFromDeck(int i)
    {
        try
        {
            var result = _cards[i];
            _cards.RemoveAt(i);
            return result;
        }
        catch (ArgumentOutOfRangeException e)
        {
            return null;
        }
    }

    public void InsertCardAtDeck(int i, Card card)
    {
        if (i is > 0 or < 0)
        {
            ValidateCardPosition(i - 1);
        }

        _cards.Insert(i, card);
    }

    public void PrintDeck()
    {
        Console.WriteLine("Current deck is:");
        for (var i = 0; i < _cards.Count; ++i)
        {
            Console.Write(_cards[i] + " ");
            if ((i + 1) % 13 == 0)
            {
                Console.WriteLine();
            }
        }
    }

    
    public string StringDeck()
    {
        var cards = "";
        foreach (var t in _cards)
        {
            cards += t + " ";
        }

        return cards;
    }

    private void ValidateCardPosition(int i)
    {
        if (i < 0 || i >= _cards.Count)
        {
            throw new IndexOutOfRangeException("Index " + i + " is out of range for cards");
        }
    }
}
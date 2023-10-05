namespace OOP_ICT.Models;

public class Dealer
{
    private readonly CardDeck _deck;

    public Dealer(CardDeck deck)
    {
        _deck = deck;
    }

    public void Shuffle()
    {
        var hand = new List<Card>();
        Card? currentCard = _deck.GetCardFromDeck(0);
        while (currentCard != null)
        {
            hand.Add(currentCard);
            currentCard = _deck.GetCardFromDeck(0);
        }

        var half = hand.Count / 2;
        for (var i = 0; i < half; ++i)
        {
            _deck.InsertCardAtDeck(i * 2, hand[i + half]);
            _deck.InsertCardAtDeck(i * 2 + 1, hand[i]);
        }
    }
}
using OOP_ICT.Models;
using OOP_ICT.Models.Enums;

var deck = new CardDeck();
var dealer = new Dealer(deck);
deck.PrintDeck();
dealer.Shuffle();
deck.PrintDeck();

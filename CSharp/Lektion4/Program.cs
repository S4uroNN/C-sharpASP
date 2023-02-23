using Lektion4;
using PowerPlant;
using PlayingCards;

//static void WarningToConsole()
//{
//    Console.WriteLine("Danger Will Robinson!!");
//}

//static void WarningToConsole2()
//{
//    Console.WriteLine("The temperature is to damn high!");
//}

//PowerPlantClass powerPlant = new PowerPlantClass();
//powerPlant.SetWarning(WarningToConsole);
//powerPlant.SetWarning(WarningToConsole2);

//for (int i = 0; i < 10; i++)
//{
//    powerPlant.HeatUp();
//}

//Console.WriteLine(5.Factorial());

//Console.WriteLine(2.Power(4));

DeckOfCards deck = new DeckOfCards();

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 13; j++)
    {
        deck.AddCard((Suits) i, (Numbers) j);
    }
}

static bool FilterBySpar(Card card)
{
    return (card.Suit == Suits.Spades);
}

List<Card> spar = deck.FilterDeck(FilterBySpar);

foreach(Card card in spar)
{
    Console.WriteLine(card);
}
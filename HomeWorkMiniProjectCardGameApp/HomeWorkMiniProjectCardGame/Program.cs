bool gameActive = true;

do
{
    // Create deck, player list and house hand
    List<PlayerModel> players = new();
    BlackjackDeck blackjackDeck = new();
    List<PlayingCardModel> houseHand = new();
    PlayerModel house = new();

    // Ask total players
    int playerCount = ConsoleQuestions.AskPlayerCount();

    // Players are all given two cards
    for (int i = 0; i < playerCount; i++)
    {
        PlayerModel player = new();

        player.Hand = blackjackDeck.DealCards();
        players.Add(player);
    }

    // Show hand for each player
    foreach (var player in players)
    {
        Console.WriteLine($"Player {players.IndexOf(player) + 1}");
        CardHand.GetHand(player);
    }

    // The house gets one card and it shown
    house.Hand = houseHand;
    houseHand.Add(blackjackDeck.DrawOneCard());
    Console.WriteLine("House");
    CardHand.GetHand(house);

    // Ask players if they want to draw
    foreach (var player in players)
    {
        ConsoleQuestions.DrawCard(player, players, blackjackDeck);
    }

    // Check for all remaining active players

    List<PlayerModel> activePlayers = new();

    foreach (var player in players)
    {
        int handValue = CardHand.GetHandValue(player);

        if (handValue < 22)
        {
            activePlayers.Add(player);
        }
    }

    // If there is no active player, return all cards and ask if player wants to continue playing
    // If there is an active player, Check who wins, players or house
    gameActive = ConsoleQuestions.CheckWinner(gameActive, house, houseHand, players, activePlayers, blackjackDeck);

} while (gameActive == true);


public abstract class Deck
{

    protected List<PlayingCardModel> fullDeck = new();
    protected List<PlayingCardModel> drawPile = new();
    protected List<PlayingCardModel> discardPile = new();
    protected void CreateDeck()
    {
        fullDeck.Clear();

        for (int suit = 0; suit < 4; suit++)
        {
            for (int val = 0; val < 13; val++)
            {
                fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)val });
            }
        }
    }

    protected void CreateMultipleDecks(int amountOfDecks)
    {
        fullDeck.Clear();

        for (int i = 0; i < amountOfDecks; i++)
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }
        }
    }


    public virtual void ShuffleDeck()
    {
        var rnd = new Random();
        drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
    }

    public abstract List<PlayingCardModel> DealCards();
    protected internal virtual PlayingCardModel DrawOneCard()
    {
        PlayingCardModel output = drawPile.Take(1).First();
        drawPile.Remove(output);
        return output;
    }
}

public class PokerDeck : Deck
{
    public PokerDeck()
    {
        CreateMultipleDecks(4);
        ShuffleDeck();
    }
    public override List<PlayingCardModel> DealCards()
    {
        List<PlayingCardModel> output = new();

        for (int i = 0; i < 5; i++)
        {
            output.Add(DrawOneCard());
        }

        return output;
    }

    public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
    {
        List<PlayingCardModel> output = new();

        foreach (var card in cardsToDiscard)
        {
            output.Add(DrawOneCard());
            discardPile.Add(card);
        }

        return output;
    }

}

public class BlackjackDeck : Deck
{
    public BlackjackDeck()
    {
        CreateMultipleDecks(4);
        ShuffleDeck();
    }
    public override List<PlayingCardModel> DealCards()
    {
        List<PlayingCardModel> output = new();

        for (int i = 0; i < 2; i++)
        {
            output.Add(DrawOneCard());
        }

        return output;
    }

    public PlayingCardModel RequestCard()
    {
        return DrawOneCard();
    }



}

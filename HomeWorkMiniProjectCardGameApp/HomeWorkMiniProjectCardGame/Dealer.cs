
// When all players have played, deal house

public class Dealer
{
    public static int dealDealer(PlayerModel house, List<PlayingCardModel> houseHand, BlackjackDeck blackjackDeck)
    {
        int handValue = CardHand.GetHandValue(house);

        do
        {
            Console.WriteLine("House");
            houseHand.Add(blackjackDeck.DrawOneCard());
            handValue = CardHand.GetHandValue(house);
            CardHand.GetHand(house);
        } while (handValue <= 16);

        return handValue;
    }
}

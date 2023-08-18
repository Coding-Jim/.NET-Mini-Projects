public class CardHand
{
    public static void GetHand(PlayerModel player)
    {
        int handValue = 0;
        int secondCardValue = 11;

        foreach (var card in player.Hand)
        {
            int cardNumber = player.Hand.IndexOf(card) + 1;
            string cardValueText = card.Value.ToString();
            int cardValueInt = (int)card.Value;
            string cardSuit = card.Suit.ToString();

            if (cardValueInt == 0)
            {
                cardValueInt += 1;
                Console.WriteLine($"Card {cardNumber}: {cardValueText}({cardValueInt}/{secondCardValue}) of {cardSuit}");
            }
            else if (1 <= cardValueInt && cardValueInt < 10)
            {
                cardValueInt += 1;
                Console.WriteLine($"Card {cardNumber}: {cardValueText}({cardValueInt}) of {cardSuit}");
            }

            else
            {
                cardValueInt = 10;
                Console.WriteLine($"Card {cardNumber}: {cardValueText}({cardValueInt}) of {cardSuit}");
            }

            handValue += cardValueInt;
        }

        bool playerHasAce = player.Hand.Any(x => (int)x.Value == 0);

        if (playerHasAce)
        {
            Console.WriteLine($"Total:  {handValue}/{handValue + secondCardValue}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Total:  {handValue}");
            Console.WriteLine();
        }
    }

    public static int GetHandValue(PlayerModel player)
    {
        int handValue = 0;

        foreach (var card in player.Hand)
        {
            int cardValueInt = (int)card.Value;

            if (cardValueInt < 10)
            {
                cardValueInt += 1;
            }
            else
            {
                cardValueInt = 10;
            }

            handValue += cardValueInt;
        }

        return handValue;
    }

}

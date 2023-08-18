public class ConsoleQuestions
{
    public static int AskPlayerCount()
    {
        bool validAmount = false;
        int playerTotal = 0;

        while (validAmount == false)
        {
            Console.Write("With how many players you want to play Blackjack? (numbers only): ");
            string playerTotalText = Console.ReadLine();
            validAmount = int.TryParse(playerTotalText, out playerTotal);

            if (validAmount == false)
            {
                Console.WriteLine("This is not a valid number, please try again.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Total players: {playerTotal}");
                Console.WriteLine();
            }
        }

        return playerTotal;
    }

    public static void DrawCard(PlayerModel p, List<PlayerModel> players, BlackjackDeck blackjackDeck)
    {
        bool wantsToDraw = true;
        int handValue = CardHand.GetHandValue(p);

        do
        {
            Console.Write($"Player {players.IndexOf(p) + 1}, do you want to draw a card? (y/n):");
            string drawAnswer = Console.ReadLine();

            if (drawAnswer.ToLower() == "y")
            {
                // add card to players hand and calculate new total
                p.Hand.Add(blackjackDeck.DrawOneCard());
                handValue = CardHand.GetHandValue(p);
                CardHand.GetHand(p);
            }
            else if (drawAnswer.ToLower() == "n")
            {
                wantsToDraw = false;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This is not a valid answer, please try again.");
            }

        } while (handValue < 21 && wantsToDraw == true);

        if (handValue == 21)
        {
            Console.WriteLine("Blackjack!");
            Console.WriteLine();
        }
        if (handValue > 21)
        {
            Console.WriteLine("Ouch, you lost.");
            Console.WriteLine();
        }
    }

    public static bool CheckWinner(bool gameActive, PlayerModel house, List<PlayingCardModel> houseHand, List<PlayerModel> players, List<PlayerModel> activePlayers, BlackjackDeck blackjackDeck)
    {
        // If there is no active player, return all cards and ask if player wants to continue playing
        if (activePlayers.Count == 0)
        {
            Console.Write("Do you want to continue playing(y/n)?: ");
            string wantsToContinue = Console.ReadLine();
            if (wantsToContinue.ToLower() == "n")
            {
                return gameActive = false;
            }
            else
            {
                return gameActive = true;
            }

        }
        // Check who wins, players or house
        else
        {
            int handValueHouse = Dealer.dealDealer(house, houseHand, blackjackDeck);

            if (handValueHouse > 21)
            {
                Console.WriteLine("The house loses, everyone still in the game wins!");
                Console.WriteLine();

                foreach (var activePlayer in activePlayers)
                {
                    int handValue = CardHand.GetHandValue(activePlayer);

                    Console.WriteLine($"Player {players.IndexOf(activePlayer) + 1}");
                    CardHand.GetHand(activePlayer);

                    if (handValue < 21)
                    {
                        Console.WriteLine("Congratulations, you won(x1)!");
                        Console.WriteLine();
                    }
                    if (handValue == 21)
                    {
                        Console.WriteLine("Congratulations, you won(x1.5)!");
                        Console.WriteLine();
                    }
                }

            }
            else
            {
                foreach (var activePlayer in activePlayers)
                {
                    int handValue = CardHand.GetHandValue(activePlayer);

                    if (handValue < handValueHouse)
                    {
                        Console.WriteLine($"Player {players.IndexOf(activePlayer) + 1}");
                        CardHand.GetHand(activePlayer);
                        Console.WriteLine("Ouch, you lost.");
                        Console.WriteLine();
                    }
                    if (handValue == handValueHouse)
                    {
                        Console.WriteLine($"Player {players.IndexOf(activePlayer) + 1}");
                        CardHand.GetHand(activePlayer);
                        Console.WriteLine("It's a tie.");
                        Console.WriteLine();
                    }
                    if (handValue > handValueHouse && handValue < 21)
                    {
                        Console.WriteLine($"Player {players.IndexOf(activePlayer) + 1}");
                        CardHand.GetHand(activePlayer);
                        Console.WriteLine("Congratulations, you won(x1)!");
                        Console.WriteLine();
                    }
                    if (handValue > handValueHouse && handValue == 21)
                    {
                        Console.WriteLine($"Player {players.IndexOf(activePlayer) + 1}");
                        CardHand.GetHand(activePlayer);
                        Console.WriteLine("Congratulations, you won(x1.5)!");
                        Console.WriteLine();
                    }

                }
            }

            // Ask if person wants to continue playing
            bool validAnswer = false;

            do
            {
                Console.Write("Do you want to continue playing(y/n)?: ");
                string wantsToContinue = Console.ReadLine();

                if (wantsToContinue.ToLower() == "n")
                {
                    Console.WriteLine("Thank you for playing!");
                    validAnswer = true;
                    return gameActive = false;
                }
                else if (wantsToContinue.ToLower() == "y")
                {
                    Console.WriteLine("That's the spirit!");
                    Console.WriteLine();
                    validAnswer = true;
                    return gameActive = true;
                }
                else
                {
                    Console.WriteLine("This is not a valid answer, please try again.");
                }
            } while (validAnswer == false);

            return gameActive;
        }

    }
}

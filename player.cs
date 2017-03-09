using System.Collections.Generic;

namespace BlackJackGame
{
    public class Player
    {
        public string name;
        public List<Card> hand { get; set; }
        public int total = 0;
        public bool isStop;
        //added sttus proprty
        public int status = -1;
        public Player(string playerName)
        {
            name = playerName;
            hand = new List<Card>();
        }

        public object draw(Deck deck)
        {
            Card card = deck.deal();
            hand.Add(card);
            total += card.value;
            return hand;
        }

        public int Play(string userInput, Deck deck)
        {
            isStop = false;
            if (userInput == "hit")
            {
                draw(deck);
            }
            if (userInput == "stop")
            {
                isStop = true;
            }


            if (total > 21)
            {
                status = 0;
                isStop = true;
            }
            if (total == 21)
            {
                isStop = true;
                status = 1;
            }
            return total;
        }

        // play method to hit/stop the game
        // declar a varialble total
        // store the value total of cards in hand of the player
        //  declare variable hit and stop,choose between hit/stop according
        // if stop, return the current total.
        // waits to check with the dealer.

        // method to change status to win/lose
        // return status;

    }
}
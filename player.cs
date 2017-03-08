using System.Collections.Generic;

namespace BlackJackGame
{
    public class Player{
        public string name;
        public List<Card> hand { get; set; }

        //added sttus proprty
        public int status{get; set;}
        public Player(string playerName){
            name=playerName;
            hand=new List<Card>();
        }

        public object draw(Deck deck){
            Card card = deck.deal();
            hand.Add(card);
            return hand;
        }

        // play method to hit/stop the game
        // declar a varialble count
        // store the value count of cards in hand of the player
        //  declare variable hit and stop,choose between hit/stop according
        // if stop, return the current count.
        // waits to check with the dealer.
        
        // method to change status to win/lose
        // return status;
        
    }
}
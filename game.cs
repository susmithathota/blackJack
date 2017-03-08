using System;
using System.Collections.Generic;

// game properties: 
// 1. deck-list of cards
// 2.dealer
// 3.list of players
namespace BlackJackGame{
    public class Game{
        
        public Player dealer;
        public Deck deck;
        public List<Player> players {get;set;}

    // tODO: pass playerNames as string to the constructor
    // add them to the playes list
        public Game(){
            deck=new Deck();
            dealer=new Player("dealer");
            
        }
    //Todod: create start game method
        public void Start(){

        }
    //   deck should be shuffeled using (deck.shuffel)
    //  loop twice for player and dealer to draw the card
    //   every player draws: invoke draw method of player class
    //   delaer should draw

    }
}
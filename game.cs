using System;
using System.Collections.Generic;

// game properties: 
// 1. deck-list of cards
// 2.dealer
// 3.list of players
namespace BlackJackGame{
    public class Game{
        
        public Player dealer;
        private Deck deck;
        public List<Player> players {get;set;}

    // tODO: pass playerNames as string to the constructor
    // add them to the playes list
        public Game(List<string>playerNames){
            deck = new Deck();
            dealer = new Player("Dealer Cash");
            Console.WriteLine("Dealer Cash created");
            players = new List<Player>();
            foreach(string name in playerNames){
                players.Add(new Player(name));
                Console.WriteLine($"Player {name} created");
            }
            players.Add(dealer);
            
        }
    //Todod: create start game method
        public void Start(){
            Console.WriteLine("Black game has now started. Please strap on your seat belt");
            deck.shuffel();
            initHit();
            hit();

        }
    //   deck should be shuffeled using (deck.shuffel)
    //  loop twice for player and dealer to draw the card
    //   every player draws: invoke draw method of player class
    //   delaer should draw

        private void initHit(){

            foreach(Player player in players){
                    Console.WriteLine($"Player {player.name} get two cards");
                    player.draw(deck);
                    player.draw(deck);
            }

        }
        private void hit(){

            foreach(Player player in players){
                string resp; 
               
                Console.WriteLine($"Player {player.name} hit(h) or stop(s)");
                resp = Console.ReadLine(); 
                if(resp == "h") {               
                    player.draw(deck);                       
                }                
                
            }

        }



        private void show(){

        }
        private void Compute(){

        }


    }
}
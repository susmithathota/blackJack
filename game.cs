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
            Compute();
            show();

        }
    //   deck should be shuffeled using (deck.shuffel)
    //  loop twice for player and dealer to draw the card
    //   every player draws: invoke draw method of player class
    //   delaer should draw
       private void show(){
            for(int i = 0; i  < players.Count - 1; i++){         
                        if(players[i].status == 1 ){                            
                                Console.WriteLine($"Player {players[i].name} Won the Game!!");                        
                            
                        }
                         else if(players[players.Count -1].status != 0){
                            Console.WriteLine($"Player {players[players.Count -1].name} Won the Game!!"); 
                         }   
                    
                    }
       }
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

                do{                   
                    
                    Console.WriteLine($"Player {player.name} hit or stop");
                    resp = Console.ReadLine(); 
                    if(resp == "stop")
                       break;
                    player.Play(resp, deck);
                    Console.WriteLine(player.total);
                    if(player.total > 21)
                        Console.WriteLine($"Player {player.name} lost");
                    if( player.status == 0 || player.status == 1 )
                         break;                  
                }while(resp == "hit");            }

        }


        private void Compute(){
                int dealerIndex = players.Count -1;
               
                if(players[dealerIndex].status != 0){
                    for(int i = 0; i  < players.Count -1; i++){         
                         if(players[i].status != 0 ){
                            if(players[i].total > players[dealerIndex].total && players[i].total <= 21){
                                players[i].status = 1;

                            } 
                            

                        }
                    }
                }else{
                        for(int i = 0; i  < players.Count -1; i++){         
                        if(players[i].status != 0 ){                            
                                players[i].status = 1;                         
                            
                        }
                            
                    
                    }


                }
        }
                


    }
}
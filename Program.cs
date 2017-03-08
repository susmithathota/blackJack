using System;
using System.Collections.Generic;

namespace BlackJackGame
{
    public class Program
    {
        public static void Main(string[] args)
        {   
<<<<<<< HEAD
             Console.WriteLine("Welcome to Black Jack");
             List<string>players =  new List<string>();
             players.Add("monday");
             players.Add("susmitha");
             players.Add("Abshir");
             Game newGame=new Game(players);
             newGame.Start();             
=======
            //  Game newGame=new Game();
            //  newGame.deck.reset();
             Deck deckObj=new Deck();
             deckObj.shuffel();
             Player player1=new Player("player1");
             Player player2=new Player("player2");
             player1.draw(deckObj);
             player1.draw(deckObj);
             while(true){
                Console.WriteLine("press hit to play/ stop to stop and enter");
                Console.WriteLine(player1.status);
                if(player1.status==0){
                    break;
                }
                string toPlay=Console.ReadLine();
                if(toPlay!="hit"){
                    break;
                }
                Console.WriteLine(player1.Play(toPlay,deckObj));
             }
             
            //  Console.WriteLine(toPlay);
>>>>>>> 38726ece0f5ca1434145cbab8ad76f12b3565868
        }
    }
}

using System;

namespace BlackJackGame
{
    public class Program
    {
        public static void Main(string[] args)
        {   
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
        }
    }
}

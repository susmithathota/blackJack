using System;

namespace BlackJackGame
{
    public class Program
    {
        public static void Main(string[] args)
        {   
             Game newGame=new Game();
             newGame.deck.reset();
             Player dealer=new Player("dealer");
        }
    }
}

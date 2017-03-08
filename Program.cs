using System;
using System.Collections.Generic;

namespace BlackJackGame
{
    public class Program
    {
        public static void Main(string[] args)
        {   
             Console.WriteLine("Welcome to Black Jack");
             List<string>players =  new List<string>();
             players.Add("monday");
             players.Add("susmitha");
             players.Add("Abshir");
             Game newGame=new Game(players);
             newGame.Start();             
        }
    }
}

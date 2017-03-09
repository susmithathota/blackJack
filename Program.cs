using System;
using System.Collections.Generic;

namespace BlackJackGame
{
    public class Program
    {
        public static void Main(string[] args)
        {   

             Console.WriteLine("Welcome to Black Jack");
             string resp;
             List<string>players =  new List<string>();
             do{                
                Console.WriteLine("Enter player name or start");
                 resp = Console.ReadLine();
                 if(resp != "start")
                 players.Add(resp);
             }while(resp !="start");            
             
             Game newGame=new Game(players);
             newGame.Start();             

        }
    }
}






using System;
using System.Collections.Generic;

namespace BlackJackGame
{
    public class Deck
    {
        public List<Card> cardList { get; set; }

        public Deck()
        {
            cardList = new List<Card>();
            reset();
        }
        public Card deal()
        {
            Card dealCard = cardList[cardList.Count - 1];
            cardList.RemoveAt(cardList.Count - 1);
            Console.WriteLine("dealt card {0},{1}", dealCard.suit, dealCard.value);
            return dealCard;
        }
        public void reset()
        {
            string[] suitsArray = { "Clubs", "Spades", "Hearts", "Diamonds" };
            string[] valArray = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            cardList.Clear();
            for (int i = 0; i < suitsArray.Length; i++)
            {
                for (int j = 0; j < valArray.Length; j++)
                {
                    if (j > 9)
                    {
                        cardList.Add(new Card(suitsArray[i], 10, valArray[j]));
                    }
                    else
                    {
                        cardList.Add(new Card(suitsArray[i], j + 1, valArray[j]));
                    }
                }
            }
        }
        public object shuffel()
        {
            Random rand = new Random();
            Console.WriteLine("shuffling {0} cards", cardList.Count);
            for (int idx = 0; idx < cardList.Count - 1; idx++)
            {
                int randIdx = rand.Next(idx + 1, cardList.Count - 1);
                Card curCard = cardList[idx];
                cardList[idx] = cardList[randIdx];
                cardList[randIdx] = curCard;
            }
            Console.WriteLine(cardList[0].suit);
            Console.WriteLine(cardList[0].value);
            return cardList;
        }
    }
}
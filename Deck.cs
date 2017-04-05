using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public string[] suits = {"Hearts", "Diamonds", "Spades", "Clubs"};
        private Random rand = new Random();
        public Deck()
        {
            Reset();
        }


        public Card Deal(){
            Card cardDealt = cards[0];
            cards.Remove(cardDealt);
            return cardDealt;
        }

        public void Reset(){
            cards = new List<Card>();
            foreach (string i in suits)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(new Card(j, i));
                }
            }
        }

        public void Shuffle(){
            for (int i = 0; i < cards.Count; i++){
                Card tempCard = cards[i];
                int myRand = rand.Next(i, cards.Count);
                cards[i] = cards[myRand];
                cards[myRand] = tempCard;
            }
        }
    }
}
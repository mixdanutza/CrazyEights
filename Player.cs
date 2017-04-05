using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();
        public Player(string myName)
        {
           name = myName;
        }

        public void Draw(Deck myDeck){
            hand.Add(myDeck.Deal());
        }

        public Card Discard(int cardNum){
            if (hand.Count > cardNum){
                Card myCard = hand[cardNum];
                hand.RemoveAt(cardNum);
                return myCard;
            }
            else {
                return null;
            }
        }
        
    }
}
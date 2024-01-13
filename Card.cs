using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BlackJack
{
    public class Card
    {

      public  string CardName { get; set; }

      public  int CardValue { get; set; }


        public List<Card> cards = new List<Card>();


        public Card(string cardName, int cardValue)
        {
         
            CardName = cardName;
            CardValue = cardValue;
        }

        public Card()
        {
            
        }

        public override string ToString()
        {
            return $"{CardName}";
        }

        
  
     
    

        public void addCards()
        {
            cards.Add(new Card("A", 11));
            cards.Add(new Card("A", 11));
            cards.Add(new Card("A", 11));
            cards.Add(new Card("A", 11));
            cards.Add(new Card("K", 10));
            cards.Add(new Card("K", 10));
            cards.Add(new Card("K", 10));
            cards.Add(new Card("K", 10));
            cards.Add(new Card("Q", 10));
            cards.Add(new Card("Q", 10));
            cards.Add(new Card("J", 10));
            cards.Add(new Card("J", 10));
            cards.Add(new Card("10", 10));
            cards.Add(new Card("10", 10));
            cards.Add(new Card("10", 10));
            cards.Add(new Card("10", 10));
            cards.Add(new Card("9", 9));
            cards.Add(new Card("9", 9));
            cards.Add(new Card("6", 6));
            cards.Add(new Card("6", 6));
            cards.Add(new Card("6", 6));
            cards.Add(new Card("5", 5));
            cards.Add(new Card("5", 5));
            cards.Add(new Card("5", 5));
            cards.Add(new Card("5", 5));
            cards.Add(new Card("9", 9));
            cards.Add(new Card("9", 9));
            cards.Add(new Card("8", 8));
            cards.Add(new Card("8", 8));
            cards.Add(new Card("8", 8));
            cards.Add(new Card("8", 8));
            cards.Add(new Card("4", 4));
            cards.Add(new Card("3", 3));
            cards.Add(new Card("3", 3));
            cards.Add(new Card("3", 3));
            cards.Add(new Card("7", 7));
            cards.Add(new Card("7", 7));
            cards.Add(new Card("7", 7));
            cards.Add(new Card("7", 7));
            cards.Add(new Card("6", 6));
            cards.Add(new Card("Q", 10));
            cards.Add(new Card("Q", 10));
            cards.Add(new Card("J", 10));
            cards.Add(new Card("J", 10));
            cards.Add(new Card("4", 4));
            cards.Add(new Card("4", 4));
            cards.Add(new Card("4", 4));
            cards.Add(new Card("3", 3));
            cards.Add(new Card("2", 2));
            cards.Add(new Card("2", 2));
            cards.Add(new Card("2", 2));
            cards.Add(new Card("2", 2));
        Random random = new Random();
int n = cards.Count;
while (n > 1)
{
    n--;
    int k = random.Next(n + 1);
    Card value = cards[k];
    cards[k] = cards[n];
    cards[n] = value;
}

        }
    }
}


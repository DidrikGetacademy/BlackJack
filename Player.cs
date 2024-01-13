using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public List<Card> PlayerCard = new List<Card>();

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public void hit(Card card, string userinput)
        {

            if (userinput == "1")
            {
                Card dealtCard = card.cards.First();
                PlayerCard.Add(dealtCard);
                card.cards.Remove(dealtCard);
                Score += dealtCard.CardValue;
                Console.WriteLine($"{Name} Hit! Card: {dealtCard}");
                Console.WriteLine($"Score: {Score}");
            }
        }

        public void Stay(Dealer dealer, string userinput, Player player, Card card)
        {
            while (dealer.Score < 17)
            {
                dealer.Hit(dealer, player, card, userinput);
            }
        }
    }
}

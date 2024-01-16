using System.Numerics;

namespace BlackJack;

public class Player
{
    public List<Card> PlayerCard = new();

    public bool AlreadyHitAce = true;
    public Player(string name)
    {
        Name = name;
        Score = 0;
        bool AlreadyHitAce = true;
    }

    public string Name { get; set; }
    public int Score { get; set; }

    public void hit(Card card, string userinput)
    {
        if (userinput == "1")
        {
            var Ace = PlayerCard.Any(x => x.CardName == "A");
            var dealtCard = card.cards.First();
            PlayerCard.Add(dealtCard);
            card.cards.Remove(dealtCard);
            Score += dealtCard.CardValue;

            if (Ace && AlreadyHitAce && Score > 21)
            {
                Score -= 10;
                Console.WriteLine($"{Name} Hit! Card: {dealtCard.CardName}");
                Console.WriteLine($"Score: {Score}");
                AlreadyHitAce = false;
            }
            else if (!AlreadyHitAce)
            {
                Console.WriteLine($"{Name} Hit! Card: {dealtCard.CardName}");
                Console.WriteLine($"Score: {Score}");
            }
        }
    }


    public void Stay(Dealer dealer, string userinput, Player player, Card card)
    {
        while (dealer.Score < 17) dealer.Hit(dealer, player, card, userinput);
    }


}
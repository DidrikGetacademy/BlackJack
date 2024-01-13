namespace BlackJack;

public class Player
{
    public List<Card> PlayerCard = new();

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public string Name { get; set; }
    public int Score { get; set; }

    public void hit(Card card, string userinput)
    {
        if (userinput == "1")
        {
            var dealtCard = card.cards.First();
            PlayerCard.Add(dealtCard);
            card.cards.Remove(dealtCard);
            Score += dealtCard.CardValue;
            Console.WriteLine($"{Name} Hit! Card: {dealtCard}");
            Console.WriteLine($"Score: {Score}");
        }
    }

    public void Stay(Dealer dealer, string userinput, Player player, Card card)
    {
        while (dealer.Score < 17) dealer.Hit(dealer, player, card, userinput);
    }
}
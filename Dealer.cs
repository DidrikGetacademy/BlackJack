namespace BlackJack;

public class Dealer
{
    public List<Card> dealerCard = new();

    public Dealer(string name)
    {
        Name = name;
        Score = 0;
    }

    public string Name { get; set; }
    public int Score { get; set; }



    public void DealOutCard(Player player, Dealer dealer, Card card)
    {
        card.addCards();
        while (player.PlayerCard.Count < 2)
        {
            var dealtCard = card.cards.First();
            player.PlayerCard.Add(dealtCard);
            card.cards.Remove(dealtCard);
            player.Score += dealtCard.CardValue;
            Console.WriteLine($"{player.Name} Card: {dealtCard}");
        }
        Console.WriteLine($"Score: ({player.Score})");
        Console.WriteLine();


        while (dealer.dealerCard.Count < 1)
        {
            var dealtCard = card.cards.First();
            dealer.dealerCard.Add(dealtCard);
            card.cards.Remove(dealtCard);
            dealer.Score += dealtCard.CardValue;
            Console.WriteLine($"{dealer.Name} Card: {dealtCard}");
            Console.WriteLine($"{dealer.Name} Card: ?");
        }

        Console.WriteLine($"Score: ({dealer.Score})");


        while (!Winner(player, dealer))
        {
            Console.WriteLine();
            Console.WriteLine("1.Hit");
            Console.WriteLine("2.Stay");
            var userinput = Console.ReadLine();
            if (userinput == "1" && player.Score < 21) player.hit(card, userinput);
            if (userinput == "2" && player.Score < 21 && dealer.Score < 21)
                player.Stay(dealer, userinput, player, card);
        }


        if (Winner(player, dealer))
        {
            if ((player.Score > dealer.Score && player.Score <= 21) || dealer.Score > 21)
            {
                Console.WriteLine("spiller Vinner");
                Console.WriteLine();
            }
            else if ((dealer.Score > player.Score && dealer.Score > 16 && dealer.Score <= 21) || player.Score > 21)
            {
                Console.WriteLine("Dealer  Vinner!");
                Console.WriteLine();
            }
            else if (dealer.Score == player.Score && dealer.Score > 16)
            {
                Console.WriteLine("Uavgjort");
                Console.WriteLine();
            }
        }
    }


    public void Hit(Dealer dealer, Player player, Card card, string userinput)
    {
        if (dealer.Score < 17 && player.Score != 21 && player.Score < 21 && userinput == "2")
        {
            var dealtCard = card.cards.First();
            dealer.dealerCard.Add(dealtCard);
            card.cards.Remove(dealtCard);
            dealer.Score += dealtCard.CardValue;
            Console.WriteLine();
            Console.WriteLine($"{dealer.Name} Hit! Card: {dealtCard}");
            Console.WriteLine($"Score: {dealer.Score}");
        }
    }


    public bool Winner(Player player, Dealer dealer)
    {
        return player.Score == 21 || player.Score > 21 || dealer.Score == 21 || dealer.Score >= 17 ||
               (dealer.Score > 17 && dealer.Score < player.Score);
    }

    public void nyttspill(Player player, Dealer dealer, Card card)
    {
        Console.WriteLine("Vil du spille på nytt?");
        var nyttspill = Console.ReadLine();
        if (nyttspill == " ") dealer.DealOutCard(player, dealer, card);
    }
}
namespace BlackJack;

public class Program
{
    private static void Main(string[] args)
    {
        var BlackJack = true;
        while (BlackJack)
        {
            var card = new Card();
            var player = new Player("Player");
            var dealer = new Dealer("Dealer");
            dealer.DealOutCard(player, dealer, card);
            dealer.nyttspill(player, dealer, card);
        }
    }
}
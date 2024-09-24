namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int user_points = 0;
            int dealer_points = 0;

            Console.WriteLine("Välkommen till spelet 21");
            Console.WriteLine("Vill du slå eller stanna?");

            string user_answer = Console.ReadLine();

            while (user_points < 21)
            {
                if (dealer_points <= 16)
                {
                    Random Dealer_Rand = new Random();
                    int Dealer_RandomNumber = Dealer_Rand.Next(1, 7);
                    dealer_points += Dealer_RandomNumber;
                    Console.WriteLine("Dealern slog: " + Dealer_RandomNumber + " Dealerns poäng: " + dealer_points);

                }
                else if (dealer_points > 16)
                {
                    Console.WriteLine("Dealern valde att stanna. Dealerns slutliga poäng: " + dealer_points);                  
                }

                if (user_answer == "stanna")
                {                                                         
                    if (user_points > dealer_points && dealer_points > 16)
                    {
                        Console.WriteLine("Du är närmare 21 än dealern och har vunnit!");
                    }
                    if (dealer_points >= 17)
                    {
                        break;
                    }
                    if (dealer_points > 21)
                    {
                        Console.WriteLine("Dealern gick över 21. Du har vunnit!");
                        break;
                    }
                }else {
                    Random Rand = new Random();
                    int randomNumber = Rand.Next(1, 7);
                    user_points += randomNumber;
                    Console.WriteLine("Du slog: " + randomNumber + ". Din poäng: " + user_points);
                    user_answer = Console.ReadLine();
                    if (user_answer == "stanna")
                    {
                        Console.WriteLine("Du har valt att stanna. Ditt slutliga poäng är " + user_points);
                    }
                }
                if (user_points > 20 && user_points < 22)
                {
                    Console.WriteLine("Du har nått 21 precis och har vunnit!");
                    Console.WriteLine("Dealern har förlorat");
                    break;
                }
                if (user_points > 21)
                {
                    Console.WriteLine("Du har gått över 21 och har förlorat!");
                    Console.WriteLine("Dealern har vunnit");
                    break;
                }  
               
                
       
            }
            if (dealer_points > user_points && dealer_points < 22)
            {
                Console.WriteLine("Dealern hade högre poäng och har vunnit spelet");
                
            }











        }
    }
}

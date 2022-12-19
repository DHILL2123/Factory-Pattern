namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of credit card would you like?");
            var userInput = Console.ReadLine();
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard(cardType:userInput);


            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge : " + cardDetails.GetAnnualCharge());
            }

            else
            {
                Console.Write("Invalid Card Type");
            }

            Console.ReadLine();

        }
    }
}

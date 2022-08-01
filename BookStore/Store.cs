using System;

namespace BookStore
{
    internal static class Store
    {
        private static float newPrice;

        public static float CalculateDiscount(float discount, Publication p)
        {
                      
            if (discount > 0 && discount < 100)
            {
                newPrice = p.Price - (p.Price * discount / 100);
                Console.WriteLine("The price with the discount of " + discount + "% is: " + newPrice + "$");
            }
            else if(discount == 0)
            {
                Console.WriteLine("There is no discount for publication " + p.Title);
            }
            else
            {
                Console.WriteLine("Invalid value of discount!");
            }
            return newPrice;
            
        }     

        public static bool IsPublicationAvailable(Publication p)
        {
            return p.Available > 0;
        }

        public static int SellPublication(Publication p, int decrease)
        {
            if (IsPublicationAvailable(p))
            {
                p.Available -= decrease;
                Console.WriteLine("The number of remaining books of publication " + p.Title + ": " + p.Available);
            }
            else
            {
                Console.WriteLine("There are no available books from publication " + p.Title);
            }
            return p.Available;
        }      
    }
}

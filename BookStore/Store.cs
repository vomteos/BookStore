using System;

namespace BookStore
{
    internal static class Store
    {
        public static float CalculateDiscount(float discount, float price)
        {
            float newPrice = price / ((100 + discount) / 100);
            Console.WriteLine("The price with the discount is: " + newPrice + "$");
            if (discount > 0 && discount < 100)
            {
                return newPrice;
                
            }
            else if(discount == 0)
            {
                Console.WriteLine("There is no discount for this publication");
            }
            else
            {
                Console.WriteLine("Invalid value of discount!");
            }
            return price;
           
        }     

        public static bool IsPublicationAvailable(int available)
        {
            return available > 0;
        }

        public static int SellPublication(int available, int decrease)
        {
            if (IsPublicationAvailable(available))
            {
                available -= decrease;
                Console.WriteLine("The number of remailing books: " + available);
            }
            else
            {
                Console.WriteLine("There are no available books.");
            }
            return available;
        }      
    }
}

using System;

namespace BookStore
{
    public class Publication
    {
        public string Title
        { get; set; }

        public float Price
        { get; set; }

        public int Available
        { get; set; }

        public Publication(string title, float price, int available)
        {
            Title = title; Price = price; Available = available;    
        }
        
        public float UpdatePrice(float price)
        {
            Price = price;
            Console.WriteLine("The price has been updated to: " + price + "$");
            return price;
        }

        public void GetDetails()
        {
            Console.WriteLine("Title: " + Title + "; Price: " + Price + "$; Number of available books: " + Available);
        }
    }
}


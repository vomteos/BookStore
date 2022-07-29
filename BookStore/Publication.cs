using System;


//properties: Title, Price, available(number of available publications)
//Methods: UpdatePrice(should update price of the publication) and Get Details (prints out the details about the publication)

//Create constructor, getters, setters
//Create object of the Publication class. 
//Update price and print out the publication object


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
        
        public void UpdatePrice(float price)
        {
            Price = price;
            Console.WriteLine("The price has been updated to: " + price + "$");
        }

        public void GetDetails()
        {
            Console.WriteLine("Title: " + Title + "; Price: " + Price + "$; Number of available books: " + Available);
        }
    }
}


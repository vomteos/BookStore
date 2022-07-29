using System;

//  Create static class Store with methods:


namespace BookStore
{
    public static class Store
    {
        // 	CalculateDiscount(discount, publication) – this will return new price after calculating discount (make sure that discount can take value between 0 and 100)
        //public int Discount
        //{
        //    get
        //    {
        //        return this.discount;
        //    }
        //    set
        //    {
        //        if (value >= 0 && value <= 100)
        //        {
        //            this.discount = value;
        //        }
        //        else
        //        {
        //            throw new ValueOutOfRangeException(string.Empty, "Inappropriate value, the value of discount should be from 0 to 100.");
        //        }
        //    }
        //}
        //public static float CalculateDiscount(float discount)
        //{
        //    Discount = discount;
        //    float newPrice;
        //    if (discount >= 0 && discount <= 100)
        //    {
        //        newPrice = Publication.Price / ((100 + discount) / 100);
        //    }
        //    return Publication.Price = newPrice;

        //}
        ////•	IsPublicationAvailable that will return is the publication available (available > 0)

        //public static int IsPublicationAvailable()
        //{
        //    var available = Publication.Available;

        //    if (available > 0)
        //    {
        //        Console.WriteLine("Number of available books:" + available);
        //    }
        //    else
        //    {
        //        Console.WriteLine("There are no available books.");

        //    }
        //}

        ////•	SellPublication(check if book is available and decrease availability)

        //public static int SellPublication(int books)
        //{
        //    var available = Publication.Available;
        //    if (available >= books)
        //    {
        //        return available - books;
        //    }
        //    else
        //    {
        //        Console.WriteLine("There are no available books.");
        //    }
        //}
    }
}

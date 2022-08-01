using System;
using System.Collections;
using System.Collections.Generic;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var publicationObj = new Publication("Harry Potter and the Chamber of secrets", 15.99F, 5);

            publicationObj.GetDetails();

            publicationObj.UpdatePrice(Store.CalculateDiscount(10, publicationObj));

            Store.SellPublication(publicationObj, 1);

            publicationObj.GetDetails();

            //create an array of 3 publications and show their details

            Publication[] books = new Publication[3];
            books[0] = new Publication("Catcher in the rye", 9.99F, 3);
            books[1] = new Publication("To kill a mockingbird", 17.99F, 4);
            books[2] = new Publication("Lord of the rings: Two towers", 18.99F, 2);

            foreach (var book in books)
            {
                book.GetDetails();
            }

            //sell a book 

            Store.SellPublication(books[1], 2);
            
            //show details of publications containing two or less books

            foreach (var book in books)
            {
                if (book.Available <= 2)
                {
                    book.GetDetails();
                }
            }
        }
    }
}

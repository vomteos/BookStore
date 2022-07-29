using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var publicationObj = new Publication("Harry Potter and the Chamber of secrets", 15.99F, 5);

            publicationObj.GetDetails();

            publicationObj.UpdatePrice(14.99F);

            publicationObj.GetDetails();


            //Use methods to calculate discount
            //Use method to check availability after Selling publication
            

            //Store.CalculateDiscount(10);

            //Store.SellPublication(3);

            //Store.IsPublicationAvailable();
        }


    }
}

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

            Store.CalculateDiscount(100,14.99F);

            Store.SellPublication(5, 1);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;


namespace DatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProdcut = DB.getProduct(1);

            Console.WriteLine(myProdcut.ProductUpc.ToString());

            Console.Read();

            IEnumerable<Sale> sales = DB.getSaleList();
            foreach (Sale s in sales)
            {
                Console.WriteLine("Sales ID:  " + s.SaleId + " \n Customer Name: " +
                    s.Customer.CustomerId + "\n Product Description: " + s.Product.ProductDescription);
            }

            String newCustomer = DB.UpdateCustomer(1);
            Console.WriteLine(newCustomer);

            String deletedProduct = DB.deleteProduct(1);
            Console.WriteLine(deletedProduct);
        }
    }
}
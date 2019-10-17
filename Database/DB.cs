using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DB
    {
        private static Demo1Entities myDb = new Demo1Entities();
        public static IEnumerable<Product> GetProducts()
        {
            return myDb.Products.ToList();
        }
        public static IEnumerable<Customer> GetCustomers()
        {
            return myDb.Customers.ToList();
        }

        public static IEnumerable<Sale> getSaleList()
        {
            return myDb.Sales.ToList();
        }

        public static Product getProduct(int id)
        {
            return myDb.Products.Find(id);
        }
        public static String UpdateCustomer(int id)
        {
            String fName = "Haroon";
            String lName = "Mas";
            Customer cus = myDb.Customers.Find(id);
            cus.CustomerFirstName = fName;
            cus.CustomerLastName = lName;
            return ("Customer: " + id + " has been updated" + " First name: " + cus.CustomerFirstName + " Last name:" + cus.CustomerLastName);

        }
        public static String deleteProduct(int id)
        {
            Product p = myDb.Products.Find(id);
            myDb.Products.Remove(p);
            myDb.SaveChanges();
            
            return ("Product: " + id + "has been deleted");
        }
    }
}

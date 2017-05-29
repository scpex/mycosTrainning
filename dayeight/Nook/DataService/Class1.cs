using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataService
{
   
    public class TestCustomer
    {
        public string CustomerID { set; get; }
        public string CompanyName { set; get; }
        public string ContractName { set; get; }
        public float? TotalOrderPrice { set; get; }

        public TestCustomer() { }
   
    }

    public class MycosShop
    {
        public string ProductCode { set; get; }
        public string ProductName { set; get; }
        public float Price { set; get; }
        public float? PriceVAT { set; get; }

        public MycosShop() { }

    }
    public class Class1
    {
        
       
        public List<TestCustomer> getCustomerAll()
        { 
            List<Customer> customerList = new List<Customer>();
            List<TestCustomer> testCustomerList = new List<TestCustomer>();
          
            try
            {
                using (var db = new NorthwindEntities())
                {
                    var test = db.Customers.Select(c => new TestCustomer()
                    {
                        CustomerID = c.CustomerID,
                        CompanyName = c.CompanyName,
                        ContractName = c.ContactName,
                        TotalOrderPrice = (float)c.Orders.Sum(o => (float)o.Order_Details.Sum(g => (float)g.Quantity * (float)g.UnitPrice))

                    }).ToList();
                    
                  
                    return test;
                }
            }catch (Exception ex) { throw ex; }
        }

        public List<MycosShop> getProductAll()
        {
            List<MycosShop> productList = new List<MycosShop>();
      

            try
            {
                using (var db = new NorthwindEntities())
                {
                    var test = db.Products.Select(p => new MycosShop()
                    {
                        ProductCode = p.ProductID.ToString(),
                        ProductName = p.ProductName,
                        Price = (float)p.UnitPrice,
                        PriceVAT = (float)((float)p.UnitPrice + (float)p.UnitPrice*0.07)

                    }).ToList();


                    return test;
                }
            }
            catch (Exception ex) { throw ex; }
        }

    }
}

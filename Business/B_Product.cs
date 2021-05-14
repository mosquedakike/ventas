using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new SalesContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ProductById(int id)
        {
            using (var db = new SalesContext())
            {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == id);
            }
        }

        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new SalesContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }
    }
}

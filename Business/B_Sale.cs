using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Sale
    {
        public static List<SaleEntity> SaleList()
        {
            using (var db = new SalesContext())
            {
                return db.Sales.ToList();
            }
        }

        public static SaleEntity SaleById(int id)
        {
            using (var db = new SalesContext())
            {
                return db.Sales.ToList().LastOrDefault(p => p.SaleId == id);
            }
        }

        public static void CreateSale(SaleEntity oSale)
        {
            using (var db = new SalesContext())
            {
                db.Sales.Add(oSale);
                db.SaveChanges();
            }
        }
    }
}

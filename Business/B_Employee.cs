using Entities;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business
{
    public class B_Employee
    {
        public static List<EmployeeEntity> EmployeeList()
        {
            using (var db = new SalesContext())
            {
                return db.Employees.ToList();
            }
        }

        public static EmployeeEntity EmployeeById(int id)
        {
            using (var db = new SalesContext())
            {
                return db.Employees.ToList().LastOrDefault(p => p.EmployeeId == id);
            }
        }

        public static void CreateEmployee(EmployeeEntity oEmployee)
        {
            using (var db = new SalesContext())
            {
                db.Employees.Add(oEmployee);
                db.SaveChanges();
            }
        }
    }
}

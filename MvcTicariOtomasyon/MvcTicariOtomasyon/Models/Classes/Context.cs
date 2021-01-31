using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MvcTicariOtomasyon.Models.Classes
{
    public class Context: DbContext
    {
        //Tabloları Entity framework ile set ettik.

        public DbSet<Admin> Admins  { get; set; }
        public DbSet<Bill> Bills  { get; set; }
        public DbSet<BillContent> BillContents  { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<Department> Departments  { get; set; }
        public DbSet<Employee> Employees  { get; set; }
        public DbSet<Expenses> Expenses  { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<SaleMovement> SaleMovements  { get; set; }

    }
}
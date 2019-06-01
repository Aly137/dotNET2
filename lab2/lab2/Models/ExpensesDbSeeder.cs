using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class ExpensesDbSeeder
    {

        public static void Initialize(ExpensesDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Expenses.Any())
            {
                return;   // DB has been seeded
            }

            context.Expenses.AddRange(
                new Expense
                {
                  Description = "Smart TV",
                  Sum = 3400,
                  Location = "Media Galaxy",
                  Date = DateTime.Parse("25/05/2019 13:23"),
                  Currency = "RON",
                  ExpenseType = ExpenseType.electronics,
                },
                new Expense
                {
                    Description = "Shoes",
                    Sum = 320,
                    Location = "Office Shoes",
                    Date = DateTime.Parse("03/05/2019 20:45"),
                    Currency = "RON",
                    ExpenseType = ExpenseType.clothes,
                },
                 new Expense
                 {
                     Description = "Rabbit",
                     Sum = 25,
                     Location = "Pet Shop",
                     Date = DateTime.Parse("030/05/2019 14:30"),
                     Currency = "Euro",
                     ExpenseType = ExpenseType.other,
                 }
            );
            context.SaveChanges();
        }
    }
}
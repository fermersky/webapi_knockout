using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication14.Models
{
    public class StaffContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }

    public class StaffDbInitializer : DropCreateDatabaseIfModelChanges<StaffContext>
    {
        protected override void Seed(StaffContext context)
        {
            context.People.Add(new Person { Id = 1, Name = "Иван Иванов", Age = 23, Married = true });
            context.People.Add(new Person { Id = 2, Name = "Петр Петренко", Age = 73, Married = true });
            context.People.Add(new Person { Id = 3, Name = "Джон Сноу", Age = 35, Married = false });
            context.People.Add(new Person { Id = 4, Name = "Эльза Гриффин", Age = 42, Married = true });
            base.Seed(context);
        }
    }
}
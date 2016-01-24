using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_lesson_3_9
{
    class MyContextInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            Person p1 = new Person { Name = "Bob", Age = 19 };
            db.Persons.Add(p1);
            db.SaveChanges();
        }
        
    }
}

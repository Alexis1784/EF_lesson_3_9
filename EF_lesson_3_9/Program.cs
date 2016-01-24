using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    
                    try
                    {
                        //Person p1 = db.Persons.FirstOrDefault(p => p.Name == "Bob");
                        //p1.Name = "Bob Senior";
                        //db.Entry(p1).State = EntityState.Modified;
                        Person p2 = new Person { Name = "Bob Junior1", Age = 1 };
                        db.Persons.Add(p2);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("transaction.Rollback!");
                        transaction.Rollback();
                    }
                }

                foreach (Person p in db.Persons.ToList())
                    Console.WriteLine("Name: {0}  Age: {1}", p.Name, p.Age);
                Console.ReadLine();
            }
        }
    }
}

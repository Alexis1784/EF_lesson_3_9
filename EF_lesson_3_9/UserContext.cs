using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_lesson_3_9
{
    class UserContext : DbContext
    {
        static UserContext()
        {
            Database.SetInitializer<UserContext>(new MyContextInitializer());
        }
        public UserContext()
            : base("EF_lesson_3_9")
        { }
        public DbSet<Person> Persons { get; set; }
       
    }
}

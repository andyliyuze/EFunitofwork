using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class MyContext: DbContext
    {
        public MyContext()
            : base("UnitOfWork")
        {

          
        }
        public DbSet<User> User { get; set; }
        public DbSet<Log> Log { get; set; }

    }
   
}

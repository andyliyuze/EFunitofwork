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
         static MyContext _myContext=null;

        public static MyContext GetSingleContext()
        {
            if (_myContext != null) {
                return _myContext; }
            else { return new MyContext(); }

        }

        public MyContext()
            : base("UnitOfWork")
        {

       
        }
        public DbSet<User> User { get; set; }
        public DbSet<Log> Log { get; set; }

    }
   
}

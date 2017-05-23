using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public  class UserRepository
    {
      private MyContext _dbContext;


      public UserRepository(MyContext dbContext) 
      {
          _dbContext = dbContext;
      }
      public void Add(User user) 
      {
          _dbContext.User.Add(user);           
      }

        public void Update(User user)
        {

            _dbContext.Entry<User>(user).State = System.Data.Entity.EntityState.Modified;
        }




    }
}

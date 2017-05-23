using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class UserSevice
    {
       private MyContext _dbContext;
       private UserRepository _userRepository;

       public UserSevice() 
       {
            _dbContext = MyContext.GetSingleContext();
           _userRepository = new UserRepository(_dbContext);       
       }

       public void AddUser(User user) 
       {
           _userRepository.Add(user);
           
           Log log = new Log { Id=Guid.NewGuid(),Happen="注册"};
           _dbContext.Log.Add(log);
          int i=    _dbContext.SaveChanges();
       
       } 

    }
}

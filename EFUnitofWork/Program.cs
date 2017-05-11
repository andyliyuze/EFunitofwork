using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {

            UserSevice _service = new UserSevice();
            User user = new User {Id=Guid.NewGuid(),Name="Andy" };
            _service.AddUser(user);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class User
    {

       public Guid Id { get; set; }
       public string Name { get; set; }
        public int Number { get; set; }
    }


   public class Log 
   {

       public Guid Id { get; set; }


       public string Happen { get; set; }
   
   }
}

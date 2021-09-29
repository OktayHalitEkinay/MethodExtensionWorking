using ConsoleUI.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Extension
{
    public static class ReturnNameExtension
    {
        public static string ReturnNameSurname(this EntityManager entityManager,string lastName)
        {
            return entityManager.ReturnName()+" "+ lastName;         
        }
    }
}

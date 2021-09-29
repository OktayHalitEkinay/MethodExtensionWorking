using ConsoleUI.Concrete;
using ConsoleUI.Extension;
using System;

namespace MethodExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityManager entityManager = new EntityManager();
            Console.WriteLine(entityManager.ReturnNameSurname("EKINAY")); 
        }
    }
}

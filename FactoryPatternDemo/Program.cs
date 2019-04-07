using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryContract;
namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryService.Factory objFactory = new FactoryService.Factory();
            IDbOperations operation = objFactory.facObject[2];
            Console.WriteLine(operation.Create());
            Console.Read();
        }
    }
}

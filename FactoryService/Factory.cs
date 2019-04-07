using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryContract;
namespace FactoryService
{
    public class Factory
    {
        public Dictionary<int,IDbOperations> facObject=new Dictionary<int,IDbOperations>();
        public Factory()
        {
            facObject.Add(1, new SqlDBService());
            facObject.Add(2, new OracleDBService());   
        }
    }
}

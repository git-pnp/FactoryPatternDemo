using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryContract;
namespace FactoryService
{
    public class OracleDBService : IDbOperations
    {
        public string Retrieve()
        {
            return "Oracle Retrieve is executed";
        }
        public string Create()
        {
            return "Oracle Create is executed";
        }
        public string Update()
        {
            return "Oracle Update is executed";
        }
        public string Delete()
        {
            return "Oracle Update is executed";
        }
    }
}

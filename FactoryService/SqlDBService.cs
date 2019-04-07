using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryContract;
namespace FactoryService
{
    public class SqlDBService : IDbOperations
    {
        public string Retrieve()
        {
            return "Sql Retrieve is executed";
        }
        public string Create()
        {
            return "Sql Create is executed";
        }
        public string Update()
        {
            return "Sql Update is executed";
        }
        public string Delete()
        {
            return "Sql Update is executed";
        }
    }
}

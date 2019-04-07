using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryContract
{
    public interface IDbOperations
    {
        string Create();
        string Retrieve();
        string Update();
        string Delete();
    }
}

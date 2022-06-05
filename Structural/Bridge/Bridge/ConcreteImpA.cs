using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImpA : IImplementation
    {
        public string OperationImp()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImpB : IImplementation
    {
        public string OperationImp()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }
}

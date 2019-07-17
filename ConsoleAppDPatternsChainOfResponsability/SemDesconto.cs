using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDPatternsChainOfResponsability
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public Double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}

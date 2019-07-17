using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDPatternsChainOfResponsability
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Adapter_ResolucaoExercicio1
{
    public sealed class SuperGeradorGrafico
    {
        public void DesenharGrafico(string titulo, List<string> x, 
            List<int> y)
        {
            //logica para gerar o grafico
            Console.WriteLine("\n ** SuperGeradorGrafico : Gerando " +
                "Gráfico com efeitos **");
        }
    }
}

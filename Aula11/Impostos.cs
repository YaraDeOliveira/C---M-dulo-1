using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    public class Impostos
    {

        public Impostos()
        {
            _porcentagemIndividual = 0.01m;
        }

        private decimal _porcentagemIndividual;
        public Impostos(decimal porcentagemIndividual)
        {
            _porcentagemIndividual = porcentagemIndividual;
        }
        

        
        public decimal CalcularISS(string estado, decimal valorServico, bool empresaIndividual)
        {
            decimal porcentagem;
            if (empresaIndividual)
            {
                porcentagem = _porcentagemIndividual;
            }

            else if (estado == "SP")
            {
                porcentagem = 0.06m;
            }
            else
            {
                porcentagem = 0.05m;
            }
            decimal valorImposto = valorServico * porcentagem;

            return valorImposto;

        }


        //Modificador de Acesso (public)
        //Retorno é um valor (decimal)
        //Nome do Método é CalcularISS 
        //Parâmetros: estado (string), valorServico (decimal)

        public decimal CalcularISS(string estado, decimal valorServico)
        {
            decimal porcentagem;
            if (estado == "SP")
            {
                porcentagem = 0.06m;
            }
            else
            {
                porcentagem = 0.05m;
            }
            decimal valorImposto = valorServico * porcentagem;

            return valorImposto;

        } 

    }
}

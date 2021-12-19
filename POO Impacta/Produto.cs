using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Impacta
{
    public class Produto
    {
        // Campos - Fields
        private string nome;
        private decimal preco;

        //Propriedade
        public string Nome 
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        
        }
    }

}

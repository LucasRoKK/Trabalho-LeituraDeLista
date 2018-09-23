using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Dirigido_2
{
    class Produto
    {
        public int cod;
        public string nome;
        public string status;

        public void Imprime()
        {
            Console.WriteLine("{0}, {1}, {2}",cod, nome, status);
        }

        public Produto(int cod, string nome, string status)
        {
            this.cod = cod;
            this.nome = nome;
            this.status = status;
        }
    }
}

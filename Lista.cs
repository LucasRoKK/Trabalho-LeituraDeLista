using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Dirigido_2
{
    class Lista
    {
        int cod;
        string nome;
        string status;

        public void Imprime()
        {
            Console.WriteLine("{0}, {1}, {2}", cod, nome, status);
        }

        public Lista(int cod, string nome, string status)
        {
            this.cod = cod;
            this.nome = nome;
            this.status = status;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Estudo_Dirigido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha;
            int c0 = 0;
            string c1 = "xxxx";
            string c2 = "xxxx";

            char[] delimitador = new char[] { ';' };

            List<Produto> produto = new List<Produto>();

            using (StreamReader file = new StreamReader(@"c:\\entrada.txt"))
            {
                while ((linha = file.ReadLine()) != null)
                {
                    string[] campos = linha.Split(delimitador, StringSplitOptions.RemoveEmptyEntries);

                    c0 = Int32.Parse(campos[0]);
                    c1 = campos[1];
                    c2 = campos[2];

                    produto.Add(new Produto(c0, c1, c2));
                }
            }

            Console.Write("Digite o status do produto(ATIVO, INATIVO ou ALTERAR PRECO): ");
            string f1 = Console.ReadLine();
            List<Lista> f2 = new List<Lista>();

            for (int i = 0; i < produto.Count; i++)
            {
                if (f1 == produto[i].status)
                {
                    c0 = produto[i].cod;
                    c1 = produto[i].nome;
                    c2 = produto[i].status;
                    f2.Add(new Lista(c0, c1, c2));
                }
                else if (f1 == produto[i].status)
                {
                    c0 = produto[i].cod;
                    c1 = produto[i].nome;
                    c2 = produto[i].status;
                    f2.Add(new Lista(c0, c1, c2));
                }
                else if (f1 == produto[i].status)
                {
                    c0 = produto[i].cod;
                    c1 = produto[i].nome;
                    c2 = produto[i].status;
                    f2.Add(new Lista(c0, c1, c2));
                }
            }

            for (int i = 0; i < f2.Count; i++)
            {
                f2[i].Imprime();
            }
            Console.ReadLine();
        }
    }
}
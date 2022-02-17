using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT2POO_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            List<Movimento> listaMovimentos = new List<Movimento>(); // Criar a lista de Movimentos
            List<Conta> listaContas = new List<Conta>(); // Criar a lista de Compras

            listaContas.Add(new Conta(1, 925, "normal", 1256));
            listaContas.Add(new Conta(2, 926, "especial", 1300));
            listaContas.Add(new Conta(3, 130, "especial", 1256));
            listaContas.Add(new Conta(4, 470, "normal", 1256));
            listaContas.Add(new Conta(5, 200, "normal", 1256));

            listaContas[0].Movimentos.Add(new Movimento("Pagamento Serviços", 300, "Debito"));
            listaContas[0].Movimentos.Add(new Movimento("Carreg. Telemovel", 1256, "Credito"));
            listaContas[1].Movimentos.Add(new Movimento("Conta Agua", 1256, "Debito"));
            listaContas[1].Movimentos.Add(new Movimento("Pagamento Serviços", 1256, "Credito"));
            listaContas[2].Movimentos.Add(new Movimento("Conta da Luz", 1256, "Debito"));

            do
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("------[1] Adicionar Conta---------");
                Console.WriteLine("------[2] Eliminar Conta----------");
                Console.WriteLine("------[3] Levantamento -----------");
                Console.WriteLine("------[4] Depósito----------------");
                Console.WriteLine("------[5] Listar Contas-----------");
                Console.WriteLine("----------------------------------");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        listaContas.Add(Conta.Criar());
                        Console.Clear();
                        break;
                    case 2:
                        listaContas = Conta.Eliminar(listaContas);
                        Console.Clear();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        for (int i = 0; i < listaContas.Count; i++)
                        {
                            Console.WriteLine(listaContas[i].ToString());
                        }
                        break;
                }
            } while (menu != 9);
        }
    }
}

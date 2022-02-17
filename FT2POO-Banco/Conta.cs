using System.Collections.Generic;
using System;
namespace FT2POO_Banco
{
    class Conta
    {

        //DEFINIR OS ATRIBUTOS E ENCAPSULAMENTO
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public string Estado { get; set; }
        public int Limite { get; set; }
        public List<Movimento> Movimentos { get; set; }

        public Conta(int numero, double saldo, string estado, int limite)
        {
            Numero = numero;
            Saldo = saldo;
            Estado = estado;
            Limite = limite;
            Movimentos = new List<Movimento>();
        }
        public Conta()
        {
            Movimentos = new List<Movimento>();
        }
        
        public static Conta Criar()
        {
            Conta conta = new Conta();

            Console.WriteLine("Numero ");
            conta.Numero=int.Parse(Console.ReadLine());
            Console.WriteLine("Saldo ");
            conta.Saldo=double.Parse(Console.ReadLine());
            Console.WriteLine("Estado ");
            conta.Estado = Console.ReadLine();
            Console.WriteLine("Limite ");
            conta.Limite = int.Parse(Console.ReadLine());

            return conta;
        }
        public static List<Conta> Eliminar(List<Conta> contas)
        {
            int numero;
            Console.WriteLine("Qual o numero de conta a eliminar? ");
            numero = int.Parse(Console.ReadLine());
            for (int i=0;i<contas.Count; i++)
            {
                if(contas[i].Numero== numero)
                {
                    contas.RemoveAt(i);
                    break;
                } 
            }
            return contas;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string texto = "Conta: " + Numero + " Saldo: " + Saldo + " Estado: " + Estado + " Limite: " + Limite;

            for (int i = 0; i < Movimentos.Count; i++)
            {
                texto += "\n" + Movimentos[i].ToString();
            }
            texto += "\n"+"-------------------------";
            return texto;
        }
    }
}

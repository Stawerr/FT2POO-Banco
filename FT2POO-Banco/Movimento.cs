using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT2POO_Banco
{
    class Movimento
    {
        //DEFINIR OS ATRIBUTOS E ENCAPSULAMENTO
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }

        //CONTRUTOR
        public Movimento(string descricao, double valor, string tipo)
        {
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return "Descricao: " + Descricao + " Valor: " + Valor + " Tipo: " + Tipo;
        }
    }
}

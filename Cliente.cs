using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Cliente
    {
        
        public string Nome { get; private set; }
        public double Saldo { get; set; }
        public int Cheque { get; set; }

        public int NumConta { get; private set; }

        public Cliente(string nome, int numConta)
        {
            Nome = nome;
            NumConta = numConta;
        }

        public Cliente(string nome, int numConta, double saldo) : this(nome, numConta)
        {
            Saldo = saldo;
        }
       

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        
        public override string ToString()
        {
            return "Conta " + NumConta + ", Titular: " + Nome + " Saldo " + Saldo;
        }



    }
}

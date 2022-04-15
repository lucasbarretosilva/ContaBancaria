using System;
using ContaBancaria;

namespace ContaBancaria;

class Program
{
    static void Main(string[] args)

    {
        Cliente conta;

        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
       
        
        Console.Write("Entre o titular da conta: ");
        string nome = Console.ReadLine();
        Console.Write("Haverá depósito inicial? (s/n)");
        char resposta = char.Parse(Console.ReadLine());

        if(resposta == 's'|| resposta == 'S')
        {
            Console.Write("Digite o valor do depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine());
            conta = new Cliente(nome,numero, depositoInicial);
        }
        else
        {
            conta = new Cliente(nome, numero);

            
        }
        Console.WriteLine();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.WriteLine("Entre um valor para depósito: ");
        double quantia = double.Parse(Console.ReadLine());
        conta.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);

        Console.WriteLine("Entre um valor para saque: ");
        double saque = double.Parse(Console.ReadLine());    
        

        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);

    }
}
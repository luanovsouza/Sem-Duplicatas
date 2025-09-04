using Sem_Duplicata.Entities;

namespace Sem_Duplicata;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos nomes de cliente voce vai cadastrar? ");
        int numberCliente = int.Parse(Console.ReadLine()!);
        
        CriandoCliente(numberCliente);
    }

    static void CriandoCliente(int clientNumber)
    {
        HashSet<Cliente> clientes = new HashSet<Cliente>();
        
        for (int i = 0; i < clientNumber; i++)
        {
            Console.Write("Digite o nome do cliente: ");
            string? name = Console.ReadLine();

            Console.WriteLine();

            clientes.Add(new Cliente(name));
        }
    }
}
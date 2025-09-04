using ClienteSemDuplicata.Entities;

namespace ClienteSemDuplicata;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Quantos nomes de cliente voce vai cadastrar? ");
            int numberCliente = int.Parse(Console.ReadLine()!);
        
            CriandoCliente(numberCliente);
        }
        catch (Exception e)
        {
            Console.WriteLine("Um erro Aconteceu: ");
            Console.WriteLine(e.Message);
        }
    }

    static void CriandoCliente(int clientNumber)
    {
        HashSet<Cliente> clientes = new HashSet<Cliente>();
        
        for (int i = 0; i < clientNumber; i++)
        {
            Console.Write($"Digite o nome do cliente #{i+1}: ");
            string name = Console.ReadLine()!;
            
            clientes.Add(new Cliente(name));
        }
        
        MostrandoCliente(clientes);
    }

    static void MostrandoCliente(HashSet<Cliente> clientes)
    {
        SortedSet<Cliente> ordemCliente = new SortedSet<Cliente>(clientes);


        Console.WriteLine($"Quantidade de Clientes: {ordemCliente.Count}");
        foreach (var clienteOrdem in ordemCliente)
        {
            Console.WriteLine($"Cliente: {clienteOrdem}");
        }
    }
}
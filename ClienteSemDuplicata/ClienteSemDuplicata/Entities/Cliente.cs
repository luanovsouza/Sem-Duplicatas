namespace ClienteSemDuplicata.Entities;

public class Cliente : IComparable<Cliente>
{
    public string Nome { get; set; }

    public Cliente(string? nome)
    {
        Nome = nome;
    }

    public override int GetHashCode()
    {
        return Nome.GetHashCode();
    }
    
    public int CompareTo(Cliente? other)
    {
        
        return Nome.CompareTo(other.Nome);
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Cliente))
        {
            return false;
        }
        
        Cliente? other = obj as Cliente;

        return Nome.Equals(other.Nome);
    }

    public override string ToString()
    {
        return $"{Nome}";
    }
}
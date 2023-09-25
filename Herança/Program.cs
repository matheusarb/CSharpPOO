Console.WriteLine("Herança!\n--------------\n");

var t = new Aluno();
t.Identificar();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void Identificar()
    {
        Console.WriteLine($"Nome: {Nome} - Email: {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}
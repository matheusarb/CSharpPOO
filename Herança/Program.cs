Console.WriteLine("Herança!\n--------------\n");

Funcionario func = new();
func.Nome = "jose";
func.Email = "jose@";
func.Empresa = "Google";
func.Salario = 9000;

Console.WriteLine(func.Nome);
Console.WriteLine(func.Email);
Console.WriteLine(func.Empresa);
Console.WriteLine(func.Salario);

var t = new Aluno();
func.Identificar();

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
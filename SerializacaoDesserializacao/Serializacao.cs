//Conceito: serialização é o processo de conversão do estado de um objeto em um formato que possa
// ser armazenado e/ou transportado num arquivo, banco de dados ou memória

// Trata-se da conversão de um objeto em um fluxo de bytes(stream), de forma que
// possa ser armazenado na memória, em arquivo ou em um banco de dados

// Modos de serialização
// I. Serialização Binária (OBSOLETO)
// Preserva fidelidade do tipo e estado de um objeto
// System.Runtime.Serialization

// II. Serialização XML ou SOAP
// Serializa somente propriedades públicas e não preserva a fidelidade de tipo
// System.Xml.Serialization

// III. Serialização JSON
// Serializa somente propriedades públicas e não preserva a fidelidade de tipo
// System.Text.Json (vem substituindo a NewtonSoft por melhor desempenho e é nativo do .NET)
// NewtonSoft.Json

using System.Text.Json.Serialization;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    
    [JsonIgnore]
    public int Idade;

    public Aluno(){}

    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }
}
// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("---Serialização e Desserialização---\n");


// I. Serialização Binária (OBSOLETA)

// II.1 Serialização JSON
// Precisamos de um construtor público parameterless
var aluno1 = new Aluno(1, "Matheus", "matheus@io.com", 32);
var caminhoArquivo1 = @"C:\dev\Serializacao\AlunoSerializado2.json";

// using(var stream = new FileStream(caminhoArquivo1,
//                     FileMode.OpenOrCreate,
//                     FileAccess.ReadWrite)){
//     JsonSerializer.Serialize(stream, aluno1);
// }

// II.1.1. Desserialização JSON
var jsonContent = File.ReadAllText(caminhoArquivo1);
var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);
// foreach(var prop in aluno.GetType().GetProperties())
//     System.Console.WriteLine($"{prop.Name} - {prop.GetValue(aluno)}");


// II.2. Serialização XML
// Precisamos de um construtor público parameterless
var caminhoArquivo2 = @"C:\dev\Serializacao\AlunoSerializado.xml";

//Serializar
// using (var writer = new StreamWriter(caminhoArquivo)){
//     serializer.Serialize(writer, aluno1);
// }

// II.2.1. Desserialização
// using(var reader = new StreamReader(caminhoArquivo2)){
//     var aluno = (Aluno)serializer.Deserialize(reader);
//     System.Console.WriteLine(@$"Aluno XML desserializado:
//         Id - {aluno.Id}
//         Nome - {aluno.Nome}
//         Email - {aluno.Email}
//         Idade - {aluno.Idade}");
// }

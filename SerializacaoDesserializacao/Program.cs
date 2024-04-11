// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

Console.WriteLine("---Serialização e Desserialização---\n");


// I. Serialização Binária (OBSOLETA)

// II. Serialização XML
// Precisamos de um construtor público parameterless
var aluno = new Aluno(1, "Matheus", "matheus@io.com", 32);
var caminhoArquivo = @"C:\dev\Serializacao\AlunoSerializado.bin";
var serializer = new XmlSerializer(typeof(Aluno));

using (var writer = new StreamWriter(caminhoArquivo)){
    serializer.Serialize(writer, aluno);
}

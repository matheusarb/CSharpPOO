// See https://aka.ms/new-console-template for more information
Console.WriteLine("----\tArquivos, Diretórios, Stream\t----\n");

// I. C# fornece diversas classes para trabalhar com arquivos:
// File, FileInfo, Directory, DirectoryInfo, Path, FileStream, StreamReader, StreamWriter

// II. Métodos:
// II.1. Criação e manipulação
// Create, Delete, Exists, Copy, Move
// II.1. Leitura e escrita
// ReadAllText, ReadAllBytes, WriteAllText, WriteAllBytes, AppendAllText

// III. Criar arquivos:
// Para criar é preciso especificar o caminho e o nome do arquivo

// IV. Classe FILE na prática:
var caminhoOrigem = @"C:\dev\arquivo.txt";
//criar arquivo
File.Create(caminhoOrigem);
File.WriteAllText(caminhoOrigem, "Criando primeiro arquivo");
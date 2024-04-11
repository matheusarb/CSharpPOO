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
// File.Create(caminhoOrigem); Se fizer assim o arquivo é criado e ficará aberto, não podendo mais ser manipulado
File.WriteAllText(caminhoOrigem, "Criando primeiro arquivo: \r\n\n");
var novoTexto = "Esse é um teste" +
                Environment.NewLine +
                "para verificar \r\n" +
                "se o código funciona";
File.AppendAllText(caminhoOrigem, novoTexto);

//Ler conteúdo do arquivo
// System.Console.WriteLine("Conteúdo e informações do arquivo:\n");
var conteudo = File.ReadAllText(caminhoOrigem);
// Ler todas as linhas forma alternativa
string[] linhas = File.ReadAllLines(caminhoOrigem);
// foreach(var linha in linhas)
    // System.Console.WriteLine(linha);
// System.Console.WriteLine(conteudo);

// Obter último acesso
// System.Console.WriteLine("Última modificação: "+ File.GetLastWriteTime(caminhoOrigem));
// System.Console.WriteLine("Último acesso: "+ File.GetLastAccessTime(caminhoOrigem));

// copiar e mover
var caminhoCopia = @"C:\dev\arquivo1_copia.txt";
var caminhoDestinho = @"C:\dev\txt\arquivo.txt";
File.Copy(caminhoOrigem, caminhoDestinho);
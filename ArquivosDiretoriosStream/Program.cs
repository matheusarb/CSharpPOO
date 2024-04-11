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
File.WriteAllText(caminhoOrigem, "Criando primeiro arquivo: \r\n");
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
// var caminhoCopia = @"C:\dev\arquivo1_copia.txt";
// var caminhoDestinho = @"C:\dev\txt\arquivo.txt";
// File.Copy(caminhoOrigem, caminhoDestinho);



// V. classe PATH na prática
// útil para manipular caminhos

var dirSeparador = Path.DirectorySeparatorChar;
// System.Console.WriteLine("Separador padrão: "+dirSeparador);

string[] diretorios = caminhoOrigem.Split(dirSeparador);
// foreach(string diretorio in diretorios)
//     System.Console.WriteLine(diretorio);

var dirArq = Path.GetDirectoryName(caminhoOrigem);
var nomeArq = Path.GetFileName(caminhoOrigem);
// System.Console.WriteLine(nomeArq);
// System.Console.WriteLine(Path.Combine(dirArq, nomeArq));



// VI. classe STREAM na prática
// VI.1. Criando FileStream
var fs1 = new FileStream(caminhoOrigem, FileMode.Open, FileAccess.Read, FileShare.Read);

var fInfo = new FileInfo(caminhoOrigem);
FileStream fs2 = fInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read);

var fs3 = File.Open(caminhoOrigem, FileMode.Open, FileAccess.Read, FileShare.Read);

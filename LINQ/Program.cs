using CSharpPOO.LINQ;

Console.WriteLine("-----Language-Integrated Query (LINQ)-----\n");

// Conjunto de tecnologias baseada na integração de recursos de consulta diretamente na linguagem C#endregion
// Permite escrever consultas em coleções tipadas usando palavras-chave do C#
// Sintaxe de consulta baseada na linguagem padrão do SQL

// 1. Query Syntax padrão ou Sintaxe de Consulta
var nomes = new List<string>{"Ana", "Maria", "Pedro", "Lair", "Hugo"};

var resultado = from item in nomes
                where item.Contains('a')
                select item;
// Exibir<string>(resultado);

// 2. Method Syntax ou Sintaxe de método
var resultado2 = nomes.Where(nome => nome.Contains('o'));
// Exibir<string>(resultado2);

// II. CONSULTAS LINQ MAIS COMUNS
// II.1. Filtrar dados .Where()
var nomesComM = nomes.Where(n => n.StartsWith('M'));

// II.2. Criar lista de string .Select()
var listaProdutos = Produto.GetProdutos();
var ordenarPorNome = listaProdutos
                        .Select(p => p.Nome)
                        .OrderBy(nome => nome);

// II.3. Filtrar por preço, ordenar por nome e criar um tipo anônimo
var produtosComAumento = listaProdutos
                .Where(p => p.Preco < 500)
                .OrderBy(p => p.Nome)
                .Select(p => new
                {
                    Nome = p.Nome?.ToUpper(),
                    PrecoAumentado = p.Preco * 1.1
                });

// foreach(var p in produtosComAumento)
//         System.Console.WriteLine($"{p.Nome}, \tPreço aumentado: {p.PrecoAumentado:C2}");

// II.4. Produtos com valor maior q 2000 e desconto de 20%
var prodMaior2000EDesconto20 = listaProdutos
                                .Where(p => p.Preco > 2000)
                                .OrderBy(p => p.Nome)
                                .Select(p => new 
                                {
                                    Nome = p.Nome?.ToUpper(),
                                    PrecoDesconto = p.Preco * 0.8
                                });


// foreach(var p in prodMaior2000EDesconto20)
//         System.Console.WriteLine($"{p.Nome}, \tPreço c desconto: {p.PrecoDesconto:C2}");

// II.5. Somatória, Média e Contagem de produtos eletrônicos
var mediaProdEletr = listaProdutos.Where(p => p.Categoria == "Eletrônicos")
                        .Average(p => p.Preco);
// System.Console.WriteLine($"A média dos produtos eletr é {mediaProdEletr:C2}");

// III.1. Métodos LINQ comuns para LOCALIZAR ELEMENTOS
// .First(), .FirstOrDefault(), .Last(), .LastOrDefault(), .Single(), .SingleOrDefault()

// IV.1. Métodos LINQ comuns para realizar AGRUPAMENTOS
// Agrupamento dos produtos por categoria
var produtosPorCategoria = listaProdutos.GroupBy(p => p.Categoria)
                            .OrderBy(p => p.Key);
foreach(var grupo in produtosPorCategoria)
{
    System.Console.WriteLine($"{grupo.Key} : {grupo.Count()}");
    
    foreach(var p in grupo)
        System.Console.WriteLine($"\t{p.Nome}\t{p.Preco:C2}\tEstoque: {p.Estoque}");
}

static void Exibir<T>(IEnumerable<T> list)
{
    foreach(var i in list)
        System.Console.WriteLine(i);
    System.Console.WriteLine();
}
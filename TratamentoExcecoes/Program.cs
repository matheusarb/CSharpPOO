// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----Tratamento Exceções-----\n");

var httpClient = new HttpClient();

var uri = "https://macoratti.net/dados/poesia.txt";
var response = httpClient.GetAsync(uri).Result;


try
{
    if(response.IsSuccessStatusCode)
    {
        Console.WriteLine("Arquivo acessado");
        Console.WriteLine("Código de status" + response.StatusCode);
    }
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
    Console.WriteLine(response.StatusCode);
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Página não encontrada");
    Console.WriteLine(response.StatusCode);
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
    Console.WriteLine(response.StatusCode);
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
    Console.WriteLine(response.StatusCode);
}
//catch(HttpRequestException ex)
//catch (Excepti)
//{

//}
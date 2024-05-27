// See https://aka.ms/new-console-template for more information
Console.WriteLine("---Assincronismo---\n");

// Programação Assíncrona:
// modelo de programação que permite q o aplicativo execute várias
// tarefas ao mesmo tempo sem bloquear a thread principal

// Programação Paralela:
// modelo de programação que permite o aplicativo execute múltiplas
// tarefas, simultaneamente, aproveitando os recursos do processador

var tempoEspera = 1000;

System.Console.WriteLine("Tecla algo para iniciar...");
Console.ReadLine();
RealizarTarefa(tempoEspera);

static void RealizarTarefa(int espera)
{
    var counter = 1;
    System.Console.WriteLine("\nIniciando tarefa:");
    while(counter < 4)
    {
        System.Console.WriteLine($"{counter}...");
        Thread.Sleep(espera);
        counter++;
    }
    System.Console.WriteLine("Tarefa conclúida");
}
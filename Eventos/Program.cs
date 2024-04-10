// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("----Eventos----\n");
// Evento é basicamente uma declaração de delegate que é um tipo de referência
// q permite que um método seja passado como argumento para outro método

// O delegate é definido pela assinatura do método que será chamado quando o evento for disparado

// No C#, um evento é um delegate "encapsulado" e depende do delegate

// Publisher(Publicador) determina quando um evento é acionado
// Subscribers(Assinantes do evento) determinam a ação q será executada em resposta ao evento

// Um evento pode ter vários assinantes. Um assinante pode manipular vários eventos de vários Publicadores
// Eventos sem assinantes nunca serão publicados
// Normalmente são usados para sinalizar ações do usuário, como cliques de botão, seleção de menus

// Prática:
// System.Console.WriteLine("usando eventos: \n");
// var pedido = new Pedido();
// pedido.OnCriarPedido += Email.Enviar;
// pedido.OnCriarPedido += SMS.Enviar;
// pedido.CriarPedido();
// pedido.OnCriar2 += Email.Enviar;
// pedido.OnCriar2 += SMS.Enviar;
// pedido.Criar2("batman.io", "719999999");

// static class Email
// {
//     public static void Enviar(object? sender, PedidoEventArgs e)
//     {
//         System.Console.WriteLine($"Enviando email para: {e.Email}");
//     }
// }

// static class SMS
// {
//     public static void Enviar(object? sender, PedidoEventArgs e)
//     {
//         System.Console.WriteLine($"Enviando SMS para: {e.Telefone}");
//     }
// }

// class Pedido
// {
//     public event EventHandler? OnCriarPedido;

//     public event EventHandler<PedidoEventArgs>? OnCriar2;

//     public void CriarPedido()
//     {
//         System.Console.WriteLine("Pedido com EventHandler");

//         if(OnCriarPedido != null)
//             OnCriarPedido(this, EventArgs.Empty);
//     }

//     public void Criar2(string email, string fone)
//     {
//         System.Console.WriteLine("Pedido com EventHandler<TEventArgs>");

//         if(OnCriar2 != null)
//             OnCriar2(this, new PedidoEventArgs{Email= email, Telefone = fone});
//     }
// }

// class PedidoEventArgs : EventArgs
// {
//     public string? Email { get; set; }
//     public string? Telefone { get; set; }
// }

// Delegates pré-definidos:
// 1. EventHandler
// 2. EventHandler<TEventArgs>

// criar o delegate
// delegate void PedidoEventHandler();

var name= "suehtam";
System.Console.WriteLine(name.InvertString());
System.Console.WriteLine(name.InvertString2());

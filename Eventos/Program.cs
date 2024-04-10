// See https://aka.ms/new-console-template for more information
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
System.Console.WriteLine("usando evento OnCriarPedido");
var pedido = new Pedido();
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;
pedido.CriarPedido();

static class Email
{
    public static void Enviar()
    {
        System.Console.WriteLine("Enviando email");
    }
}

static class SMS
{
    public static void Enviar()
    {
        System.Console.WriteLine("Enviando SMS");
    }
}

class Pedido
{
    public event PedidoEventHandler? OnCriarPedido;

    public void CriarPedido()
    {
        System.Console.WriteLine("Pedido criado");
        
        if(OnCriarPedido != null)
            OnCriarPedido();
    }
}

delegate void PedidoEventHandler();
// See https://aka.ms/new-console-template for more information
using Delegates;

Console.WriteLine("-----Delegates-----\n");

// Conceito: Delegate é um tipo que representa referências a métodos com uma lista de parâmetros
// e um tipo de retorno específicos

// Formas de declaração
var resultado = Calculadora.Somar(2, 2);
// Console.WriteLine(resultado);

DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
var resultado1 = calc.Invoke(20, 30);
// Console.WriteLine(resultado1);

DelegateCalculadora calc2 = Calculadora.Somar;
var resultado2 = calc2.Invoke(120, 150);
// Console.WriteLine(resultado2);

DelegateCalculadora calc3 = (float x, float y) => Calculadora.Somar(x, y);
var resultado3 = calc3.Invoke(1000, 1500);
// Console.WriteLine(resultado3);

// 1. SingleCast Delegate 
//Forma mais simples
DelegateCalculadora calc4 = Calculadora.Subtrair;
var resultado4 = calc4.Invoke(120, 150);
// Console.WriteLine(resultado4);

Console.ReadKey();


// 2. MultiCast Delegate
DelegateCalculadora delegateMulticast = Calculadora.Somar;
delegateMulticast += Calculadora.Subtrair;
var resultado5 = delegateMulticast(10, 5);
System.Console.WriteLine(resultado5);


// 3. Funções anonimas

public delegate float DelegateCalculadora(float x, float y);


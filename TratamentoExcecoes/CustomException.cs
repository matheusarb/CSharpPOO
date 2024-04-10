using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes;

internal class CustomException : Exception
{
    public CustomException()
    {
        
    }
    
    public CustomException(string message)
        :base(message)
    {
        Console.WriteLine("Exceção personalizada");
    }
    
    public CustomException(string message, Exception inner)
        : base(message, inner)
    {
        Console.WriteLine("Exceção personalizada");
        Console.WriteLine(inner.Message);
        Console.WriteLine(inner.StackTrace);
        Console.WriteLine(inner.Source);
    }
}

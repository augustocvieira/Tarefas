using System;
using System.Runtime.Serialization;

namespace Tarefas.Application.Exceptions;

public class TarefaInvalidaException : Exception
{
    public TarefaInvalidaException()
    {
    }

    protected TarefaInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public TarefaInvalidaException(string message) : base(message)
    {
    }

    public TarefaInvalidaException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
using System;
using System.Runtime.Serialization;

namespace Tarefas.Application.Exceptions;

public class UsuarioInvalidoException : Exception
{
    public UsuarioInvalidoException()
    {
    }

    protected UsuarioInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public UsuarioInvalidoException(string message) : base(message)
    {
    }

    public UsuarioInvalidoException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
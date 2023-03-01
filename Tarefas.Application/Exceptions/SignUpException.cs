using System;
using System.Runtime.Serialization;

namespace Tarefas.Application.Exceptions;

public class SignUpException : Exception
{
    public SignUpException()
    {
    }

    protected SignUpException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public SignUpException(string? message) : base(message)
    {
    }

    public SignUpException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
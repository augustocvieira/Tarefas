using System;
using System.Runtime.Serialization;

namespace Tarefas.Application.Exceptions;

public class SignInException : Exception
{
    public SignInException()
    {
    }

    protected SignInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public SignInException(string? message) : base(message)
    {
    }

    public SignInException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
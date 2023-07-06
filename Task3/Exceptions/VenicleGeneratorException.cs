namespace Task3.Exceptions;

public class VenicleGeneratorException : Exception
{
    public override string Message { get; }

    public VenicleGeneratorException(string message)
    {
        Message = message;
    }
}
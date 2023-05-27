namespace EntityFramework.Exceptions.Common.Exceptions;

public class NumericOverflowException : DbUpdateException
{
    public NumericOverflowException()
    {
    }

    public NumericOverflowException(string message) : base(message)
    {
    }

    public NumericOverflowException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public NumericOverflowException(string message, IReadOnlyList<EntityEntry> entries) : base(message, entries)
    {
    }

    public NumericOverflowException(string message, Exception innerException, IReadOnlyList<EntityEntry> entries) : base(message, innerException, entries)
    {
    }

    public NumericOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
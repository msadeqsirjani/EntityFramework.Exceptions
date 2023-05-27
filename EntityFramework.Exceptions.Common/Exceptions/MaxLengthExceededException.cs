namespace EntityFramework.Exceptions.Common;

public class MaxLengthExceededException : DbUpdateException
{
    public MaxLengthExceededException()
    {
    }

    public MaxLengthExceededException(string message) : base(message)
    {
    }

    public MaxLengthExceededException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public MaxLengthExceededException(string message, IReadOnlyList<EntityEntry> entries) : base(message, entries)
    {
    }

    public MaxLengthExceededException(string message, Exception innerException, IReadOnlyList<EntityEntry> entries) : base(message, innerException, entries)
    {
    }

    public MaxLengthExceededException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
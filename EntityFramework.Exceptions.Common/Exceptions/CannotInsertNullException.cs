namespace EntityFramework.Exceptions.Common.Exceptions;

public class CannotInsertNullException : DbUpdateException
{
    public CannotInsertNullException()
    {
    }

    public CannotInsertNullException(string message) : base(message)
    {
    }

    public CannotInsertNullException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public CannotInsertNullException(string message, IReadOnlyList<EntityEntry> entries) : base(message, entries)
    {
    }

    public CannotInsertNullException(string message, Exception innerException, IReadOnlyList<EntityEntry> entries) : base(message, innerException, entries)
    {
    }

    public CannotInsertNullException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
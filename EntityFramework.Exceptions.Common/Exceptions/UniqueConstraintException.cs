namespace EntityFramework.Exceptions.Common.Exceptions;

public class UniqueConstraintException : DbUpdateException
{
    public UniqueConstraintException()
    {
    }

    public UniqueConstraintException(string message) : base(message)
    {
    }

    public UniqueConstraintException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public UniqueConstraintException(string message, IReadOnlyList<EntityEntry> entries) : base(message, entries)
    {
    }

    public UniqueConstraintException(string message, Exception innerException, IReadOnlyList<EntityEntry> entries) : base(message, innerException, entries)
    {
    }

    public UniqueConstraintException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
namespace EntityFramework.Exceptions.Common;

public class ReferenceConstraintException : DbUpdateException
{
    public ReferenceConstraintException()
    {
    }

    public ReferenceConstraintException(string message) : base(message)
    {
    }

    public ReferenceConstraintException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public ReferenceConstraintException(string message, IReadOnlyList<EntityEntry> entries) : base(message, entries)
    {
    }

    public ReferenceConstraintException(string message, Exception innerException, IReadOnlyList<EntityEntry> entries) : base(message, innerException, entries)
    {
    }

    public ReferenceConstraintException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
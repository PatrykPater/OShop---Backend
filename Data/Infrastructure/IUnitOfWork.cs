namespace Data.Infrastructure
{
    public interface IUnitOfWork
    {
        DBContext DB { get; }
    }
}
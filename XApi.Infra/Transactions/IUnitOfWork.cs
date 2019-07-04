namespace XApi.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}

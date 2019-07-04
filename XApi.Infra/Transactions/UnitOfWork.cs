using XApi.Infra.Persistence;

namespace XApi.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly XApiContext _context;

        public UnitOfWork(XApiContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}

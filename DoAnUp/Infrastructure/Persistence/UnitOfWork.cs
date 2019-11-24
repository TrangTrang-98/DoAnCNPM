using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repository;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RegisterContext _context;

        public UnitOfWork(RegisterContext context)
        {
            _context = context;
            //User = new UserRepository(context);
        }

        public IPatientRepository Patient { get; } // cung ten vơi IUnitOfWork.IPatientRepository

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
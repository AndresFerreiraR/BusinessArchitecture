using Pacagroup.Ecommerce.Infraestructura.Interface;

namespace Pacagroup.Ecommerce.Infraestructura.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICustomersRepository Cutomers { get; }

        public IUsersRepository Users { get; }

        public UnitOfWork(ICustomersRepository cutomers, IUsersRepository users)
        {
            Cutomers = cutomers;
            Users = users;
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}

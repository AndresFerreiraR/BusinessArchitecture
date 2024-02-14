using Pacagroup.Ecommerce.Application.Interface.Persistence;

namespace Pacagroup.Ecommerce.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICustomersRepository Customers { get; }

        public IUsersRepository Users { get; }
        public ICategoriesRepository Categories { get; }

        public UnitOfWork(ICustomersRepository cutomers,
                          IUsersRepository users,
                          ICategoriesRepository categories)
        {
            Customers = cutomers;
            Users = users;
            Categories = categories;
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}

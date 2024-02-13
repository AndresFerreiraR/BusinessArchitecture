using Pacagroup.Ecommerce.Infraestructura.Interface;

namespace Pacagroup.Ecommerce.Infraestructura.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICustomersRepository Cutomers { get; }

        public IUsersRepository Users { get; }
        public ICategoriesRepository Categories { get; }

        public UnitOfWork(ICustomersRepository cutomers, 
                          IUsersRepository users,
                          ICategoriesRepository categories)
        {
            Cutomers = cutomers;
            Users = users;
            Categories = categories;
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}

using Pacagroup.Ecommerce.Application.Interface.Persistence;
using Pacagroup.Ecommerce.Persistence.Context;
using System.Threading;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICustomersRepository Customers { get; }

        public IUsersRepository Users { get; }
        public ICategoriesRepository Categories { get; }

        public IDiscountRepository Discount { get; }

        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ICustomersRepository cutomers,
                          IUsersRepository users,
                          ICategoriesRepository categories,
                          IDiscountRepository discount,
                          ApplicationDbContext dbContext)
        {
            Customers = cutomers;
            Users = users;
            Categories = categories;
            Discount = discount;
            _dbContext = dbContext;
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }

        public async Task<int> Save(CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}

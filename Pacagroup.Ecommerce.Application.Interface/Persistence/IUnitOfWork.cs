using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.Interface.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomersRepository Customers { get; }
        IUsersRepository Users { get; }
        ICategoriesRepository Categories { get; }
        IDiscountRepository Discount {  get; }

        Task<int> Save(CancellationToken cancellationToken);
    }
}

using System;

namespace Pacagroup.Ecommerce.Infraestructura.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomersRepository Cutomers { get; }
        IUsersRepository Users { get; }


    }
}

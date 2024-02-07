using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Infraestructura.Interface
{
    public interface IUsersRepository : IGenericRepository<Users>
    {
        Users Authenticate(string userName, string password);
    }
}

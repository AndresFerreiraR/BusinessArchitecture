
namespace Pacagroup.Ecommerce.Domain.Core
{
    using Pacagroup.Ecommerce.Domain.Entity;
    using Pacagroup.Ecommerce.Domain.Interface;
    using Pacagroup.Ecommerce.Infraestructura.Interface;


    public class UsersDomain : IUsersDomain
    {

        private readonly IUsersRepository _usersRepository;

        public UsersDomain(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }


        public Users Authenticate(string userName, string password)
        {
            return _usersRepository.Authenticate(userName, password);
        }
    }
}

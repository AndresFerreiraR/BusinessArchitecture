
namespace Pacagroup.Ecommerce.Infraestructura.Repository
{
    using Dapper;
    using Pacagroup.Ecommerce.Domain.Entity;
    using Pacagroup.Ecommerce.Infraestructura.Interface;
    using Pacagroup.Ecommerce.Transversal.Common;

    /// <summary>
    /// 
    /// </summary>
    public class UsersRepository : IUsersRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IConnectionFactory _connectionFactory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionFactory"></param>
        public UsersRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Users Authenticate(string userName, string password)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsersGetByUserAndPassword";

                var parameters = new DynamicParameters();
                parameters.Add("UserName", userName);
                parameters.Add("Password", password);

                var user = connection.QuerySingle<Users>(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure);

                return user;
            }
        }
    }
}


namespace Pacagroup.Ecommerce.Infraestructura.Repository
{
    using Dapper;
    using Pacagroup.Ecommerce.Domain.Entity;
    using Pacagroup.Ecommerce.Infraestructura.Data;
    using Pacagroup.Ecommerce.Infraestructura.Interface;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public class UsersRepository : IUsersRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly DapperContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public UsersRepository(DapperContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Users Authenticate(string userName, string password)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "UsersGetByUserAndPassword";

                var parameters = new DynamicParameters();
                parameters.Add("UserName", userName);
                parameters.Add("Password", password);

                var user = connection.QuerySingle<Users>(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure);

                return user;
            }
        }

        public bool Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Users Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Users>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Users> GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Users entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertAsync(Users entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Users entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateAsync(Users entity)
        {
            throw new System.NotImplementedException();
        }
    }
}

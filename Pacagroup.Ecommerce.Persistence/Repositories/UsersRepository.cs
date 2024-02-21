namespace Pacagroup.Ecommerce.Persistence.Repositories
{
    using Dapper;
    using Pacagroup.Ecommerce.Application.Interface.Persistence;
    using Pacagroup.Ecommerce.Domain.Entities;
    using Pacagroup.Ecommerce.Persistence.Context;
    using System;
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
        public async Task<User> Authenticate(string userName, string password)
        {
            var user = new User();
            try
            {
                using var connection = _context.CreateConnection();
                var query = "UsersGetByUserAndPassword";

                var parameters = new DynamicParameters();
                parameters.Add("UserName", userName);
                parameters.Add("Password", password);

                user = await connection.QuerySingleOrDefaultAsync<User>(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }

            return user;
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public User Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllWithPagination(int pageNumber, int pageSize)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertAsync(User entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateAsync(User entity)
        {
            throw new System.NotImplementedException();
        }
    }
}

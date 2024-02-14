using Dapper;
using Pacagroup.Ecommerce.Application.Interface.Persistence;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Persistence.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {

        private readonly DapperContext _context;


        public CategoriesRepository(DapperContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Category>> GetAll()
        {
            using var connection = _context.CreateConnection();
            var query = "SELECT * FROM Categories";

            var categories = await connection.QueryAsync<Category>(query, commandType: System.Data.CommandType.Text);
            return categories;
        }
    }
}

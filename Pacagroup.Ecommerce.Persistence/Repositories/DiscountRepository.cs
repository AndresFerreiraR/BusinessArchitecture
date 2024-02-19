
namespace Pacagroup.Ecommerce.Persistence.Repositories
{

    using Microsoft.EntityFrameworkCore;
    using Pacagroup.Ecommerce.Application.Interface.Persistence;
    using Pacagroup.Ecommerce.Domain.Entities;
    using Pacagroup.Ecommerce.Persistence.Context;
    using Pacagroup.Ecommerce.Persistence.Mocks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;


    public class DiscountRepository : IDiscountRepository
    {

        protected readonly ApplicationDbContext _dbContext;


        public DiscountRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        #region Métodos Síncronos


        public bool Update(Discount entity)
        {
            throw new NotImplementedException();
        }


        public int Count()
        {
            throw new NotImplementedException();
        }


        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }


        public Discount Get(string id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Discount> GetAll()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Discount> GetAllWithPagination(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }


        public bool Insert(Discount entity)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Méodos Asíncronos


        public async Task<bool> InsertAsync(Discount entity)
        {
            _dbContext.Add(entity);
            return await Task.FromResult(true);
        }


        public async Task<bool> UpdateAsync(Discount discount)
        {
            var entity = await _dbContext.Set<Discount>().AsNoTracking()
                                         .SingleOrDefaultAsync(x => x.Id.Equals(discount.Id));

            if(entity == null)
            {
                return await Task.FromResult(false);
            }

            entity.Name = discount.Name;
            entity.Description = discount.Description;
            entity.Percent = discount.Percent;
            entity.Status = discount.Status;

            _dbContext.Update(entity);

            return await Task.FromResult(true);
        }


        public async Task<bool> DeleteAsync(string id)
        {
            var entity = await _dbContext.Set<Discount>().AsNoTracking()
                                         .SingleOrDefaultAsync(x => x.Id.Equals(int.Parse(id)));

            if (entity == null)
            {
                return await Task.FromResult(false);
            }

            _dbContext.Remove(entity);
            return await Task.FromResult(true);
        }

        public async Task<List<Discount>> GetAllAsync(CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Set<Discount>().AsNoTracking().ToListAsync(cancellationToken);

            return entity;
                                         
        }


        public async Task<Discount> GetAsync(int id, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Set<Discount>().AsNoTracking().SingleOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
            return entity;
        }

                
        public async Task<IEnumerable<Discount>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            var faker = new DiscountGetAllWithPaginationAsyncBogusConfig();
            var result = await Task.Run(() => faker.Generate(1000));

            return result.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }


        public async Task<int> CountAsync()
        {
            return await Task.Run(() => 1000);
        }


        public Task<IEnumerable<Discount>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Discount> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

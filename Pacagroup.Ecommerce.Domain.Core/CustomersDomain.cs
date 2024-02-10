using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infraestructura.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {

        private readonly IUnitOfWork _unitOfWork;

        public CustomersDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Métodos Sincronos

        public bool Insert(Customers customers)
        {
            return _unitOfWork.Cutomers.Insert(customers);
        }
        public bool Update(Customers customers)
        {
            return _unitOfWork.Cutomers.Update(customers);
        }
        public bool Delete(string customerId)
        {
            return _unitOfWork.Cutomers.Delete(customerId);
        }
        public Customers Get(string customerId)
        {
            return _unitOfWork.Cutomers.Get(customerId);
        }
        public IEnumerable<Customers> GetAll()
        {
            return _unitOfWork.Cutomers.GetAll();
        }

        public IEnumerable<Customers> GetAllWithPagination(int pageNumber, int pageSize)
        {
            return _unitOfWork.Cutomers.GetAllWithPagination(pageNumber, pageSize);
        }

        public int Count()
        {
            return _unitOfWork.Cutomers.Count();
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(Customers customers)
        {
            return await _unitOfWork.Cutomers.InsertAsync(customers);
        }
        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _unitOfWork.Cutomers.UpdateAsync(customers);
        }
        public async Task<bool> DeleteAsync(string customerId)
        {
            return await _unitOfWork.Cutomers.DeleteAsync(customerId);
        }
        public async Task<Customers> GetAsync(string customerId)
        {
            return await _unitOfWork.Cutomers.GetAsync(customerId);
        }
        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _unitOfWork.Cutomers.GetAllAsync();
        }

        public async Task<IEnumerable<Customers>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            return await _unitOfWork.Cutomers.GetAllWithPaginationAsync(pageNumber, pageSize);
        }

        public async Task<int> CountAsync()
        {
            return await _unitOfWork.Cutomers.CountAsync();
        }

        #endregion
    }
}

using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.Interface.UseCases
{
    public interface IDiscountApplication
    {
        Task<Response<bool>> CreateAsync(DiscountDto discountDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> UpdateAsync(DiscountDto discountDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<Response<DiscountDto>> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<Response<List<DiscountDto>>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<ResponsePagination<IEnumerable<DiscountDto>>> GetAllWithPagination(int pageNumber, int pageSize);
    }
}

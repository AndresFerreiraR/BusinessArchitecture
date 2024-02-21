using MediatR;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.UseCases.Customers.Queries.GetAllWithPaginationQuery
{
    public sealed record class GetAllWithPaginationCustomerQuery : IRequest<ResponsePagination<IEnumerable<CustomerDto>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}


namespace Pacagroup.Ecommerce.Application.UseCases.Customers.Commands.DeleteCustomerCommand
{
    using AutoMapper;
    using MediatR;
    using Pacagroup.Ecommerce.Application.Interface.Persistence;
    using Pacagroup.Ecommerce.Transversal.Common;
    using System.Threading;
    using System.Threading.Tasks;

    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, Response<bool>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteCustomerHandler(IUnitOfWork unitOfWork,
                                     IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<bool>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = new Response<bool>();

            response.Data = await _unitOfWork.Customers.DeleteAsync(request.CustomerId);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Eliminacion exitosa!!!";
            }

            return response;
        }
    }
}

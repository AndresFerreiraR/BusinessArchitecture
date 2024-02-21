
namespace Pacagroup.Ecommerce.Application.UseCases.Users.CreateUsersTokenCommand
{
    using AutoMapper;
    using MediatR;
    using Pacagroup.Ecommerce.Application.DTO;
    using Pacagroup.Ecommerce.Application.Interface.Persistence;
    using Pacagroup.Ecommerce.Application.Validator;
    using Pacagroup.Ecommerce.Transversal.Common;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public class CreateUsersTokenHandler : IRequestHandler<CreateUsersTokenCommand, Response<UserDto>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public CreateUsersTokenHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        async
        public Task<Response<UserDto>> Handle(CreateUsersTokenCommand request, CancellationToken cancellationToken)
        {
            var response = new Response<UserDto>();

            var user = await _unitOfWork.Users.Authenticate(request.UserName, request.password);
            response.Data = _mapper.Map<UserDto>(user);
            response.IsSuccess = true;
            response.Message = "Authentication successful!!!";

            return response;
        }
    }
}


namespace Pacagroup.Ecommerce.Application.UseCases.Users
{
    using AutoMapper;
    using Pacagroup.Ecommerce.Application.DTO;
    using Pacagroup.Ecommerce.Application.Interface.Persistence;
    using Pacagroup.Ecommerce.Application.Interface.UseCases;
    using Pacagroup.Ecommerce.Transversal.Common;
    using System;


    public class UsersApplication : IUsersApplication
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UsersApplication(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public Response<UserDto> Authenticate(string userName, string password)
        {
            var response = new Response<UserDto>();
            try
            {
                var user = _unitOfWork.Users.Authenticate(userName, password);
                response.Data = _mapper.Map<UserDto>(user);
                response.IsSuccess = true;
                response.Message = "Authentication successful!!!";


            }
            catch (InvalidOperationException op)
            {
                response.IsSuccess = true;
                response.Message = "User not found";
            }
            catch (Exception ex)
            {

                throw;
            }

            return response;
        }
    }
}

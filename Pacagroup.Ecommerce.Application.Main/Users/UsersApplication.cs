namespace Pacagroup.Ecommerce.Application.UseCases.Users
{
    using AutoMapper;
    using Pacagroup.Ecommerce.Application.DTO;
    using Pacagroup.Ecommerce.Application.Interface.Persistence;
    using Pacagroup.Ecommerce.Application.Interface.UseCases;
    using Pacagroup.Ecommerce.Application.Validator;
    using Pacagroup.Ecommerce.Transversal.Common;
    using System;


    public class UsersApplication : IUsersApplication
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UsersDtoValidator _userDtoValidator;
        public UsersApplication(IUnitOfWork unitOfWork, IMapper mapper, UsersDtoValidator userDtoValidator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userDtoValidator = userDtoValidator;
        }


        public Response<UserDto> Authenticate(string userName, string password)
        {
            var response = new Response<UserDto>();
            var validation = _userDtoValidator.Validate(new UserDto()
            {
                UserName = userName,
                Password = password
            });
            if (!validation.IsValid)
            {
                response.Message = "validation errors";
                response.Errors = validation.Errors;
                return response;
            }
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

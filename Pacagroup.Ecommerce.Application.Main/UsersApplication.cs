
namespace Pacagroup.Ecommerce.Application.Main
{
    using AutoMapper;
    using Pacagroup.Ecommerce.Application.DTO;
    using Pacagroup.Ecommerce.Application.Interface;
    using Pacagroup.Ecommerce.Domain.Interface;
    using Pacagroup.Ecommerce.Transversal.Common;
    using System;


    public class UsersApplication : IUsersApplication
    {

        private readonly IUsersDomain _usersDomain;
        private readonly IMapper _mapper;
        public UsersApplication(IUsersDomain usersDomain, IMapper mapper)
        {
            _usersDomain = usersDomain;
            _mapper = mapper;
        }


        public Response<UsersDto> Authenticate(string userName, string password)
        {
            var response = new Response<UsersDto>();
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                response.Message = "Parameters cannot be empty";

                return response;
            }
            try
            {
                var user = _usersDomain.Authenticate(userName, password);
                response.Data = _mapper.Map<UsersDto>(user);
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

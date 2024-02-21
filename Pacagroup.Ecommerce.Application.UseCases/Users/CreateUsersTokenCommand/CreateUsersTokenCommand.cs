using MediatR;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.UseCases.Users.CreateUsersTokenCommand
{
    public sealed record class CreateUsersTokenCommand : IRequest<Response<UserDto>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

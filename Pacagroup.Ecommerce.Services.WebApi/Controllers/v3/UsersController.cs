﻿using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace Pacagroup.Ecommerce.Services.WebApi.Controllers.v3
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using Pacagroup.Ecommerce.Application.DTO;
    using Pacagroup.Ecommerce.Application.UseCases.Users.CreateUsersTokenCommand;
    using Pacagroup.Ecommerce.Services.WebApi.Helpers;
    using Pacagroup.Ecommerce.Transversal.Common;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;


    [Authorize]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("3.0")]
    public class UsersController : Controller
    {

        private readonly IMediator _mediator;
        private readonly AppSettings _appSettings;

        public UsersController(IMediator mediator, IOptions<AppSettings> appSettings)
        {
            _mediator = mediator;
            _appSettings = appSettings.Value;
        }


        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] CreateUsersTokenCommand command)
        {

            var response = await _mediator.Send(command);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                {
                    response.Data.Token = BuildToken(response);
                    return Ok(response);
                }
                else
                {
                    return NotFound(response);
                }
            }

            return BadRequest(response);
        }


        private string BuildToken(Response<UserDto> usersDto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usersDto.Data.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _appSettings.Issuer,
                Audience = _appSettings.Audience,
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenScript = tokenHandler.WriteToken(token);

            return tokenScript;
        }
    }
}

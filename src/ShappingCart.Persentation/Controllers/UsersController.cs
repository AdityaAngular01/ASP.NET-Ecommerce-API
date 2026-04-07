using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ShoppingCart.Presentation.Abstractions;

namespace ShoppingCart.Presentation.Controllers
{
    public sealed class UsersController : ApiBaseController
    {
        public UsersController(ISender sender) : base(sender)
        {
        }

        [HttpPost("[action]")]
        [ProduceResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult CreateUser()
        {
            return Ok();
        }
    }
}
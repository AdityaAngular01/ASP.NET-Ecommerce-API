using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Presentation.Abstractions
{
    [ApiController]
    [Route("api/[controller]")]
    [Producers("application/json")]
    public abstract class ApiBaseController : ControllerBase
    {
        protected readonly ISender Sender;
        
        public ApiBaseController(ISender sender)
        {
            Sender = sender;
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjMongoDBAPI10062024.Models;
using ProjMongoDBAPI10062024.Services;

namespace ProjMongoDBAPI10062024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly  AddressService _addressService;

        public AddressesController(AddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public ActionResult<List<Address>> Get()
        {
            return _addressService.Get();
        }
    }
}

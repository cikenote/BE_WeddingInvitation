using Wedding.DataAccess.IRepository;
using Wedding.Model.DTO;
using Wedding.Service.IService;
using Wedding.Utility.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Wedding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = StaticUserRoles.Customer)]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _GuestService;

        public GuestController(IGuestService GuestService)
        {
            _GuestService = GuestService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDTO>> GetAllGuests(
            [FromQuery] string? filterOn,
            [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy,
            [FromQuery] bool? isAscending,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10)
        {
            var responseDto = await _GuestService.GetAll(User, filterOn, filterQuery, sortBy, isAscending, pageNumber, pageSize);
            return StatusCode(responseDto.StatusCode, responseDto);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ResponseDTO>> GetGuestById(Guid id)
        {
            var responseDto = await _GuestService.GetById(id);
            return StatusCode(responseDto.StatusCode, responseDto);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ResponseDTO>> UpdateGuest(Guid id, UpdateGuestDTO updateGuestDTO)
        {
            var responseDto = await _GuestService.UpdateById(updateGuestDTO);
            return StatusCode(responseDto.StatusCode, responseDto);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ResponseDTO>> DeleteGuest(Guid id)
        {
            var responseDto = await _GuestService.DeleteById(id);
            return StatusCode(responseDto.StatusCode, responseDto);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDTO>> CreateEmailTemplate(CreateGuestDTO createGuestDTO)
        {
            var responseDto = await _GuestService.CreateById(createGuestDTO);
            return StatusCode(responseDto.StatusCode, responseDto);
        }
    }
}
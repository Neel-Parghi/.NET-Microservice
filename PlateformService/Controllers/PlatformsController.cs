using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Business.Interface;
using PlatformService.Dto;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPlatformManager _PlatformManager;

        public PlatformsController(IPlatformManager PlatformManager, IMapper mapper)
        {
            _mapper = mapper;
            _PlatformManager = PlatformManager;
        }

        [HttpGet("Get/{id}", Name = "GetPlatformById")]
        public ActionResult GetPlatformById(int id)
        {
            PlatformReadDto? data = _PlatformManager.GetPlatformById(id);
            
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        [HttpGet("Get/All")]
        public ActionResult<IEnumerable<PlatformReadDto>> GetAllPlatforms()
        {
            return Ok(_PlatformManager.GetAllPlatforms());
        }
        
        [HttpPost("Create")]
        public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto platform)
        {
            PlatformReadDto platformReadDto = _PlatformManager.CreatePlatform(platform);
            return CreatedAtRoute(nameof(GetPlatformById), new { Id = platformReadDto.Id }, platformReadDto);
        }
    }
}

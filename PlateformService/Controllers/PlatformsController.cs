using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Business.Interface;

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

        [HttpGet("Get/{id}")]
        public ActionResult GetPlatformById(int id)
        {
            return Ok(_PlatformManager.GetPlatformById(id));
        }

        [HttpGet("Get/All")]
        public ActionResult GetAllPlatforms()
        {
            return Ok(_PlatformManager.GetAllPlatforms());
        }
        
        [HttpPost("Create")]
        public ActionResult CreatePlatform()
        {
            return Ok(_PlatformManager.GetAllPlatforms());
        }

    }
}

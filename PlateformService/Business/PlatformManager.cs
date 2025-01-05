using AutoMapper;
using PlatformService.Business.Interface;
using PlatformService.Data.Interface;
using PlatformService.Dto;
using PlatformService.Models;

namespace PlatformService.Business
{
    public class PlatformManager : IPlatformManager
    {
        public readonly IMapper _mapper;
        public readonly IPlatformRepository _platformRepository;
        public PlatformManager(IMapper mapper,IPlatformRepository platformRepository) 
        {
            _mapper = mapper;
            _platformRepository = platformRepository;
        }
        public PlatformReadDto CreatePlatform(PlatformCreateDto platformDto)
        {
            Platform platform = _mapper.Map<Platform>(platformDto);
            _platformRepository.CreatePlatform(platform);
            _platformRepository.SaveChanges();

            return _mapper.Map<PlatformReadDto>(platform);
        }

        public IEnumerable<PlatformReadDto> GetAllPlatforms()
        {
            IEnumerable<Platform> platforms = _platformRepository.GetAllPlatforms();
            return _mapper.Map<IEnumerable<PlatformReadDto>>(platforms);
        }

        public PlatformReadDto? GetPlatformById(int id)
        {
            Platform? platform = _platformRepository.GetPlatformById(id);
            if (platform == null)
            {
                return null;
            }
            return _mapper.Map<PlatformReadDto>(platform);
        }
    }
}

using PlatformService.Dto;

namespace PlatformService.Business.Interface
{
    public interface IPlatformManager
    {
        IEnumerable<PlatformReadDto> GetAllPlatforms();

        PlatformReadDto? GetPlatformById(int id);

        PlatformReadDto CreatePlatform(PlatformCreateDto Platform);
    }
}

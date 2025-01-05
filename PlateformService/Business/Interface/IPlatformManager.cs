using PlatformService.Models;

namespace PlatformService.Business.Interface
{
    public interface IPlatformManager
    {
        IEnumerable<Platform> GetAllPlatforms();

        Platform GetPlatformById(int id);

        void CreatePlatform(Platform Platform);
    }
}

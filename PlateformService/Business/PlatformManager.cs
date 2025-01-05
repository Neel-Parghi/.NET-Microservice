using PlatformService.Business.Interface;
using PlatformService.Data.Interface;
using PlatformService.Models;

namespace PlatformService.Business
{
    public class PlatformManager : IPlatformManager
    {
        public readonly IPlatformRepository _platformRepository;
        public PlatformManager(IPlatformRepository platformRepository) 
        {
            _platformRepository = platformRepository;
        }
        public void CreatePlatform(Platform Platform)
        {
            _platformRepository.CreatePlatform(Platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _platformRepository.GetAllPlatforms();
        }

        public Platform GetPlatformById(int id)
        {
            return _platformRepository.GetPlatformById(id);
        }
    }
}

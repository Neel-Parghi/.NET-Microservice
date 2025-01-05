using PlateformService.Models;

namespace PlateformService.Data.Interface
{
    public interface IPlateformRepository
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlateforms();

        Platform GetPlateformById(int id);

        void CreatePlateform(Platform plateform);
    }
}

using PlateformService.Data.Interface;
using PlateformService.Models;

namespace PlateformService.Data
{
    public class PlateformRepository : IPlateformRepository
    {
        private readonly AppDbContext _appDbContext;

        public PlateformRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreatePlateform(Platform plateform)
        {
            if(plateform == null)
            {
                throw new ArgumentNullException(nameof(plateform));
            }
            _appDbContext.Add(plateform);
        }

        public IEnumerable<Platform> GetAllPlateforms()
        {
            return [.. _appDbContext.Plateforms];
        }

        public Platform GetPlateformById(int id)
        {
            return _appDbContext.Plateforms.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return _appDbContext.SaveChanges() >= 0;
        }
    }
}

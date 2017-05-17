
using Dream.Model.Models;
using Dream.EntityFrameworkCore;
using Dream.IRepository.IReposotories;

namespace Dream.Repository.Repositories
{
    public class MenuRepository : BaseRepository<Menu>,IMenuRepository
    {
        public MenuRepository(BaseDbContext dbContext) : base(dbContext)
        {
        }

        
    }
}

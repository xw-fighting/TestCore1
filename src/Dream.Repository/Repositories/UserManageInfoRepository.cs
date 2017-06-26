using Dream.IRepository.IReposotories;
using Dream.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Dream.EntityFrameworkCore;

namespace Dream.Repository.Repositories
{
    public class UserManageInfoRepository : BaseRepository<UserManageInfo>, IUserManageInfoRepository
    {
        public UserManageInfoRepository(BaseDbContext dbContext) : base(dbContext)
        {
        }
    }
}

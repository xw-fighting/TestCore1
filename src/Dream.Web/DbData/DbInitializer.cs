using Dream.EntityFrameworkCore;

namespace Dream.Web.DbData
{
    public class DbInitializer
    {
        public static void Initialize(BaseDbContext context)
        {
            context.Database.EnsureCreated();

        }

    }
}

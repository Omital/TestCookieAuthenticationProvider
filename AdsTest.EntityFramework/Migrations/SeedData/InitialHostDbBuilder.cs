using AdsTest.EntityFramework;
using EntityFramework.DynamicFilters;

namespace AdsTest.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AdsTestDbContext _context;

        public InitialHostDbBuilder(AdsTestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

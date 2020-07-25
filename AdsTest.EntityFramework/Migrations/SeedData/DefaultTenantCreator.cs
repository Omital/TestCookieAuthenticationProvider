using System.Linq;
using AdsTest.EntityFramework;
using AdsTest.MultiTenancy;

namespace AdsTest.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AdsTestDbContext _context;

        public DefaultTenantCreator(AdsTestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AdsTest.EntityFramework;

namespace AdsTest.Migrator
{
    [DependsOn(typeof(AdsTestDataModule))]
    public class AdsTestMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AdsTestDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
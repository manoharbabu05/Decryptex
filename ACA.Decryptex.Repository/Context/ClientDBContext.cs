using ACA.Decryptex.Cache.Provider.Interface;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace ACA.Decryptex.Repository.Context
{
    public class ClientDBContext : DbContext
    {
        private ITenantProvider iTenantProvider;

        public ClientDBContext(ITenantProvider _iTenantProvider)
        {
            iTenantProvider = _iTenantProvider;
        }

        public virtual DbSet<ApplicationConfiguration> ApplicationConfigurations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(iTenantProvider.GetCurrentTenantConnectionString());
        }
    }
}
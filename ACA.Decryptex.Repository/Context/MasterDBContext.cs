using ACA.Decryptex.Core.DecryptexRepository.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace ACA.Decryptex.Repository.Context
{
    public class MasterDBContext : DbContext
    {
        public MasterDBContext(DbContextOptions<MasterDBContext> option) : base(option)
        {
        }

        public virtual DbSet<ClientMaster> ClientMasters { get; set; }
    }
}
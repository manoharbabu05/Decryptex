using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACA.Decryptex.Core.DecryptexRepository.EntityModel
{
    [Table("ClientMaster")]
    public class ClientMaster
    {
        [Key]
        public int ClientId { get; set; }

        public string ClientName { get; set; }
        public string ClientConnectionString { get; set; }
    }
}
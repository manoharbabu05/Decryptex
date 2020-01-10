using System.ComponentModel.DataAnnotations.Schema;

namespace ACA.Decryptex.Core.DecryptexRepository.EntityModel
{
    [Table("ApplicationConfiguration")]
    public class ApplicationConfiguration
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
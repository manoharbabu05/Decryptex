namespace ACA.Decryptex.Core.DecryptexRepository.EntityModel
{
    public class VMApplicationConfiguration
    {
        public VMApplicationConfiguration(ApplicationConfiguration applicationConfiguration)
        {
            DataDescription = applicationConfiguration.Description;
            Identity = applicationConfiguration.Id;
            DataKey = applicationConfiguration.Key;
            ActiveStatus = applicationConfiguration.IsActive;
            DataValue = applicationConfiguration.Value;
        }

        public bool ActiveStatus { get; set; }
        public string DataDescription { get; set; }
        public string DataKey { get; set; }
        public string DataValue { get; set; }
        public int Identity { get; set; }
    }
}
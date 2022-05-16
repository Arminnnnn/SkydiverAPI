namespace Skydiver.Models
{
    public class SkydiverDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string SkydiverCollectionName { get; set; } = null!;
    }
}

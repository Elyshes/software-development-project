namespace SoftwareStore.Core
{
    using System.IO;

    public class SoftwarePackage
    {
        public SoftwarePackage(VersionRange compatibleHardware, Stream software, Version softwareVersion)
        {
            this.CompatibleHardware = compatibleHardware;
            this.Software = software;
            this.SoftwareVersion = softwareVersion;
        }

        public VersionRange CompatibleHardware { get; private set; }

        public Stream Software { get; private set; }

        public Version SoftwareVersion { get; private set; }

        public string Description { get; set; }
    }
}
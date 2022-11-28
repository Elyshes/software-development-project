namespace SoftwareStore.Core
{
    public class SystemUnit
    {
        public SystemUnit(Version hardwareVersion, Version softwareVersion, int serialnumber)
        {
            HardwareVersion = hardwareVersion;
            SoftwareVersion = softwareVersion;
            Serialnumber = serialnumber;
        }

        public Version HardwareVersion { get; private set; }

        public Version SoftwareVersion { get; private set; }

        public int Serialnumber { get; private set; }

        public void Update(Version softwareVersion)
        {
            
        }

        public bool IsSoftwarePackageApplicableForUpdate(SoftwarePackage softwarePackage)
        {
            //Check if given package can be applied.
            return false;
        }
    }
}
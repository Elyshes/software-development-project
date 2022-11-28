namespace SoftwareStore.Core
{
    public struct VersionRange
    {
        public VersionRange(Version lowerLimt, Version upperLimit)
            :this()
        {
            this.LowerLimt = lowerLimt;
            this.UpperLimit = upperLimit;
        }

        public Version LowerLimt { get; private set; }

        public Version UpperLimit { get; private set; }
    }
}
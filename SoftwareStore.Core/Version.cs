namespace SoftwareStore.Core
{
    public struct Version
    {
        public Version(int major, int minior, int patch)
            :this()
        {
            this.Major = major;
            this.Minior = minior;
            this.Patch = patch;
        }

        public int Major { get; private set; }

        public int Minior { get; private set; }

        public int Patch { get; private set; }
    }
}
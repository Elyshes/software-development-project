namespace SoftwareStore.Core
{
    public class SoftwareOrderItem
    {
        public SoftwareOrderItem(SystemUnit system)
        {
            this.TargetSystemUnit = system;
        }

        public DeploymentStatus Status { get; private set; }

        public SystemUnit TargetSystemUnit { get; private set; }

        public SoftwarePackage OrderedSoftware { get; private set; }

        public void SetOrderedSoftware(SoftwarePackage orderedSoftware)
        {
            //Is software compatible to system?
            //Is software already installed?
            //Is software older than installed?
            this.OrderedSoftware = orderedSoftware;
        }

        public void SoftwareIsDelivered()
        {
            
        }
    }
}
namespace SoftwareStore.Core
{
    using System.Collections.Generic;

    public class SoftwareOrder
    {
        private readonly List<SoftwareOrderItem> orderItems = new List<SoftwareOrderItem>();

        public IEnumerable<SoftwareOrderItem> OrderItem
        {
            get
            {
                return this.orderItems;
            }
        }

        public DeploymentStatus Status { get; private set; }

        public IEnumerable<SoftwareOrderItem> OrderItems
        {
            get
            {
                return this.orderItems;
            }
        }

        void AddItem(SoftwareOrderItem item)
        {
            
        }

        public void RemoveItem(SoftwareOrderItem item)
        {
            
        }
    }
}
namespace WindowsFormsApp.Models.Resources
{
    public class ResourceAmount
    {
        public ResourceType resourceType { get; set; }
        public double amount { get; set; }

        public ResourceAmount(ResourceType resourceType, double amount)
        {
            this.resourceType = resourceType;
            this.amount = amount;
        }
    }
}

namespace WindowsFormsApp.Models.Resources
{
    public class ResourceAmount
    {
        public ResourceType resourceType;
        public double amount;

        public ResourceAmount(ResourceType resourceType, double amount)
        {
            this.resourceType = resourceType;
            this.amount = amount;
        }
    }
}

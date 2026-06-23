using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class Warehouse
    {
        public int id { get; private set; }

        protected List<ResourceAmount> resourceList = new List<ResourceAmount>();

        public List<ResourceAmount> ResourceList
        {
            get { return resourceList; }
        }

        public Warehouse(int id)
        {
            this.id = id;
        }

        public double GetAmount(ResourceType type)
        {
            double result = 0;

            foreach (ResourceAmount r in resourceList)
            {
                if (r.resourceType == type)
                {
                    result = r.amount;
                }
            }

            return result;
        }

        public bool HasResources(List<ResourceAmount> required)
        {
            bool allFound = true;

            foreach (ResourceAmount item in required)
            {
                double amount = GetAmount(item.resourceType);
                if (amount < item.amount)
                {
                    allFound = false;
                }
            }

            return allFound;
        }

        public void AddResources(List<ResourceAmount> resources)
        {
            foreach (ResourceAmount item in resources)
            {
                bool found = false;

                foreach (ResourceAmount r in resourceList)
                {
                    if (r.resourceType == item.resourceType)
                    {
                        r.amount = r.amount + item.amount;
                        found = true;
                    }
                }

                if (found == false)
                {
                    ResourceAmount newResource = new ResourceAmount(item.resourceType, item.amount);
                    resourceList.Add(newResource);
                }
            }
        }

        public void RemoveResources(List<ResourceAmount> resources)
        {
            foreach (ResourceAmount item in resources)
            {
                foreach (ResourceAmount r in resourceList)
                {
                    if (r.resourceType == item.resourceType)
                    {
                        double newAmount = r.amount - item.amount;
                        if (newAmount < 0)
                        {
                            newAmount = 0;
                        }
                        r.amount = newAmount;
                    }
                }
            }
        }
    }
}

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
                        continue;
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
                for (int i = resourceList.Count - 1; i >= 0; i--)
                {
                    if (resourceList[i].resourceType == item.resourceType)
                    {
                        resourceList[i].amount -= item.amount;
                        if (resourceList[i].amount <= 0)
                            resourceList.RemoveAt(i);
                    }
                }
            }
        }

        public void RemoveAll()
        {
            resourceList.Clear();
        }
    }
}

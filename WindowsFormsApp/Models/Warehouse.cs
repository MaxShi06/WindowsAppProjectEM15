using System;
using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class Warehouse
    {
        public int id;
        public List<ResourceAmount> resourceList = new List<ResourceAmount>();

        public double GetAmount(ResourceType type)
        {
            foreach (var r in resourceList)
                if (r.resourceType == type)
                    return r.amount;
            return 0;
        }

        public bool HasResources(IEnumerable<ResourceAmount> required)
        {
            foreach (var item in required)
                if (GetAmount(item.resourceType) < item.amount)
                    return false;
            return true;
        }

        public void AddResources(IEnumerable<ResourceAmount> resources)
        {
            foreach (var item in resources)
            {
                bool found = false;
                foreach (var r in resourceList)
                {
                    if (r.resourceType == item.resourceType)
                    {
                        r.amount += item.amount;
                        found = true;
                        break;
                    }
                }
                if (!found)
                    resourceList.Add(new ResourceAmount(item.resourceType, item.amount));
            }
        }

        public void RemoveResources(IEnumerable<ResourceAmount> resources)
        {
            foreach (var item in resources)
            {
                foreach (var r in resourceList)
                {
                    if (r.resourceType == item.resourceType)
                    {
                        r.amount = Math.Max(0, r.amount - item.amount);
                        break;
                    }
                }
            }
        }
    }
}

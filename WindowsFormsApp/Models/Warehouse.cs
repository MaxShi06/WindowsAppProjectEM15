using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class Warehouse
    {
        public int id;
        public List<ResourceAmount> resourceList = new List<ResourceAmount>();

        public bool HasResources(List<ResourceAmount> required)
        {
            foreach (var item in required)
            {
                ResourceAmount found = null;
                foreach (var r in resourceList)
                    if (r.resourceType == item.resourceType)
                        found = r;

                if (found == null || found.amount < item.amount)
                    return false;
            }
            return true;
        }

        public void AddResources(List<ResourceAmount> resources)
        {
            foreach (var item in resources)
            {
                ResourceAmount found = null;
                foreach (var r in resourceList)
                    if (r.resourceType == item.resourceType)
                        found = r;

                if (found != null)
                    found.amount += item.amount;
                else
                    resourceList.Add(new ResourceAmount(item.resourceType, item.amount));
            }
        }

        public void RemoveResources(List<ResourceAmount> resources)
        {
            foreach (var item in resources)
            {
                foreach (var r in resourceList)
                {
                    if (r.resourceType == item.resourceType)
                    {
                        r.amount -= item.amount;
                        break;
                    }
                }
            }
        }
    }
}
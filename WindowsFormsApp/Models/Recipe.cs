using System;
using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class Recipe
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Duration { get; private set; }

        private List<ResourceAmount> requiredResources = new List<ResourceAmount>();
        private List<ResourceAmount> receivedResources = new List<ResourceAmount>();

        public List<ResourceAmount> RequiredResources
        {
            get { return requiredResources; }
        }

        public List<ResourceAmount> ReceivedResources
        {
            get { return receivedResources; }
        }

        public Recipe(int id, string name, int duration)
        {
            Id = id;
            SetName(name);
            SetDuration(duration);
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Name = name;
            else
                throw new ArgumentException("Назва рецепту не може бути порожньою");
        }

        public void SetDuration(int duration)
        {
            if (duration > 0)
                Duration = duration;
            else
                throw new ArgumentOutOfRangeException("duration", "Тривалість повинна бути більшою за 0");
        }

        public void AddRequiredResource(ResourceType type, double amount)
        {
            bool found = false;

            foreach (ResourceAmount r in requiredResources)
            {
                if (r.resourceType == type)
                {
                    r.amount = amount;
                    found = true;
                }
            }

            if (found == false)
            {
                ResourceAmount newResource = new ResourceAmount(type, amount);
                requiredResources.Add(newResource);
            }
        }

        public void RemoveRequiredResource(ResourceType type)
        {
            requiredResources.RemoveAll(resourse => resourse.resourceType == type);
        }

        public void AddReceivedResource(ResourceType type, double amount)
        {
            bool found = false;

            foreach (ResourceAmount r in receivedResources)
            {
                if (r.resourceType == type)
                {
                    r.amount = amount;
                    found = true;
                }
            }

            if (found == false)
            {
                ResourceAmount newResource = new ResourceAmount(type, amount);
                receivedResources.Add(newResource);
            }
        }

        public void RemoveReceivedResource(ResourceType type)
        {
            int index = 0;
            while (index < receivedResources.Count)
            {
                if (receivedResources[index].resourceType == type)
                {
                    receivedResources.RemoveAt(index);
                }
                else
                {
                    index = index + 1;
                }
            }
        }
    }
}

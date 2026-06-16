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
        public IReadOnlyList<ResourceAmount> RequiredResources => _required.AsReadOnly();
        public IReadOnlyList<ResourceAmount> ReceivedResources => _received.AsReadOnly();

        private readonly List<ResourceAmount> _required = new List<ResourceAmount>();
        private readonly List<ResourceAmount> _received = new List<ResourceAmount>();

        public Recipe(int id, string name, int duration)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Назва рецепту не може бути порожньою");
            if (duration <= 0)
                throw new ArgumentOutOfRangeException("duration", "Тривалість повинна бути більшою за 0");

            Id = id;
            Name = name;
            Duration = duration;
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
            foreach (var r in _required)
                if (r.resourceType == type) { r.amount = amount; return; }
            _required.Add(new ResourceAmount(type, amount));
        }

        public void RemoveRequiredResource(ResourceType type)
        {
            _required.RemoveAll(r => r.resourceType == type);
        }

        public void AddReceivedResource(ResourceType type, double amount)
        {
            foreach (var r in _received)
                if (r.resourceType == type) { r.amount = amount; return; }
            _received.Add(new ResourceAmount(type, amount));
        }

        public void RemoveReceivedResource(ResourceType type)
        {
            _received.RemoveAll(r => r.resourceType == type);
        }
    }
}

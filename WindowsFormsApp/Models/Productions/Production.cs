using System;
using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public abstract class Production
    {
        public int id;

        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    throw new ArgumentException("Назва підприємства не може бути порожньою");
            }
        }

        private double _efficiency = 100.0;
        public double efficiency
        {
            get { return _efficiency; }
            set
            {
                if (value >= 0 && value <= 100)
                    _efficiency = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Ефективність повинна бути від 0 до 100");
            }
        }

        public List<Recipe> recipeList = new List<Recipe>();
        public Recipe activeRecipe;

        public void SetActiveRecipe(Recipe recipe)
        {
            if (recipeList.Contains(recipe))
                activeRecipe = recipe;
        }

        public virtual void Produce(Warehouse warehouse, ref int availableElectricity, Action<string> log = null)
        {
            if (activeRecipe == null) return;

            int electricityNeeded = 0;
            var warehouseResources = new List<ResourceAmount>();

            foreach (var resource in activeRecipe.RequiredResources)
            {
                if (resource.resourceType == ResourceType.Electricity)
                    electricityNeeded += (int)resource.amount;
                else
                    warehouseResources.Add(resource);
            }

            if (availableElectricity < electricityNeeded)
            {
                log?.Invoke($"  [{name}] Не вистачає електрики: є {availableElectricity}, треба {electricityNeeded}");
                return;
            }
            if (!warehouse.HasResources(warehouseResources))
            {
                log?.Invoke($"  [{name}] Не вистачає ресурсів на складі");
                return;
            }

            availableElectricity -= electricityNeeded;
            warehouse.RemoveResources(warehouseResources);

            var produced = new List<ResourceAmount>();
            foreach (var resource in activeRecipe.ReceivedResources)
            {
                double actualAmount = resource.amount * (efficiency / 100.0);
                produced.Add(new ResourceAmount(resource.resourceType, actualAmount));
                log?.Invoke($"  [{name}] Вироблено: {actualAmount:F1} {resource.resourceType.DisplayName()}");
            }
            warehouse.AddResources(produced);
        }
    }
}

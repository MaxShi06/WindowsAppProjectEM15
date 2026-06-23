using System;
using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public abstract class Production
    {
        public int id { get; private set; }

        private string nameValue;
        public string name
        {
            get { return nameValue; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nameValue = value;
                else
                    throw new ArgumentException("Назва підприємства не може бути порожньою");
            }
        }

        private double efficiencyValue = 100.0;
        public double efficiency
        {
            get { return efficiencyValue; }
            set
            {
                if (value >= 0 && value <= 100)
                    efficiencyValue = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Ефективність повинна бути від 0 до 100");
            }
        }

        public List<Recipe> recipeList = new List<Recipe>();
        public Recipe activeRecipe;

        protected Production(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void SetActiveRecipe(Recipe recipe)
        {
            if (recipeList.Contains(recipe))
                activeRecipe = recipe;
        }

        public virtual void Produce(Concern concern)
        {
            if (activeRecipe == null)
            {
                return;
            }

            int electricityNeeded = 0;
            List<ResourceAmount> warehouseResources = new List<ResourceAmount>();

            foreach (ResourceAmount resource in activeRecipe.RequiredResources)
            {
                if (resource.resourceType == ResourceType.Electricity)
                {
                    electricityNeeded = electricityNeeded + (int)resource.amount;
                }
                else
                {
                    warehouseResources.Add(resource);
                }
            }

            if (concern.availableElectricity < electricityNeeded)
            {
                concern.log.Add("  [" + name + "] Не вистачає електрики: є " + concern.availableElectricity + ", треба " + electricityNeeded);
                return;
            }

            if (!concern.warehouse.HasResources(warehouseResources))
            {
                concern.log.Add("  [" + name + "] Не вистачає ресурсів на складі");
                return;
            }

            concern.availableElectricity = concern.availableElectricity - electricityNeeded;
            concern.warehouse.RemoveResources(warehouseResources);

            List<ResourceAmount> produced = new List<ResourceAmount>();

            foreach (ResourceAmount resource in activeRecipe.ReceivedResources)
            {
                double actualAmount = resource.amount * (efficiency / 100.0);
                ResourceAmount producedResource = new ResourceAmount(resource.resourceType, actualAmount);
                produced.Add(producedResource);
                concern.log.Add("  [" + name + "] Вироблено: " + actualAmount.ToString("F1") + " " + resource.resourceType.DisplayName());
            }

            concern.warehouse.AddResources(produced);
        }
    }
}

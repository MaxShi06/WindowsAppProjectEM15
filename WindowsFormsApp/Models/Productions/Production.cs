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

        public abstract ProductionType GetProductionType();

        public static Production Create(int id, string name, ProductionType type, double efficiency)
        {
            Production p;
            switch (type)
            {
                case ProductionType.PowerStation:     p = PowerStation.Create(id, name);     break;
                case ProductionType.CoalMine:         p = CoalMine.Create(id, name);         break;
                case ProductionType.IronMine:         p = IronMine.Create(id, name);         break;
                case ProductionType.OilWell:          p = OilWell.Create(id, name);          break;
                case ProductionType.SteelPlant:       p = SteelPlant.Create(id, name);       break;
                case ProductionType.OilRefinery:      p = OilRefinery.Create(id, name);      break;
                case ProductionType.ApplianceFactory: p = ApplianceFactory.Create(id, name); break;
                default: throw new InvalidOperationException("Unknown production type");
            }
            p.efficiency = efficiency;
            return p;
        }

        public void SetActiveRecipe(Recipe recipe)
        {
            if (recipeList.Contains(recipe))
                activeRecipe = recipe;
        }

        public virtual void Produce(Warehouse warehouse, List<string> log)
        {
            if (activeRecipe == null)
            {
                log.Add($"  [{name}] Рецепт не встановлено");
                return;
            }

            int electricityNeeded = 0;
            List<ResourceAmount> warehouseResources = new List<ResourceAmount>();

            foreach (ResourceAmount resource in activeRecipe.RequiredResources)
            {
                if (resource.resourceType == ResourceType.Electricity)
                    electricityNeeded = electricityNeeded + (int)resource.amount;
                else
                    warehouseResources.Add(resource);
            }

            if (warehouse.GetAmount(ResourceType.Electricity) < electricityNeeded)
            {
                log.Add($"  [{name}] Не вистачає електрики");
                return;
            }

            if (!warehouse.HasResources(warehouseResources))
            {
                log.Add($"  [{name}] Не вистачає ресурсів на складі");
                return;
            }

            List<ResourceAmount> electricityUsed = new List<ResourceAmount>();
            electricityUsed.Add(new ResourceAmount(ResourceType.Electricity, electricityNeeded));
            warehouse.RemoveResources(electricityUsed);
            warehouse.RemoveResources(warehouseResources);

            List<ResourceAmount> produced = new List<ResourceAmount>();
            foreach (ResourceAmount resource in activeRecipe.ReceivedResources)
            {
                double actualAmount = resource.amount * (efficiency / 100.0);
                produced.Add(new ResourceAmount(resource.resourceType, actualAmount));
                log.Add($"  [{name}] Вироблено: {actualAmount:F1} {resource.resourceType.DisplayName()}");
            }

            warehouse.AddResources(produced);
        }
    }
}
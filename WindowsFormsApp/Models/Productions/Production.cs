using System;
using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public abstract class Production
    {
        public int id;
        public string name;
        public List<Recipe> recipeList = new List<Recipe>();
        public Recipe activeRecipe;
        public double efficiency = 100.0;

        public void SetActiveRecipe(Recipe recipe)
        {
            if (recipeList.Contains(recipe))
                activeRecipe = recipe;
        }

        public abstract void Produce(Warehouse warehouse, ref int availableElectricity);

        
        protected void ProduceWithElectricity(Warehouse warehouse, ref int availableElectricity)
        {
            if (activeRecipe == null) return;

           
            int electricityNeeded = 0;
            List<ResourceAmount> warehouseResources = new List<ResourceAmount>();

            foreach (var resource in activeRecipe.requiredResourcesList)
            {
                if (resource.resourceType == ResourceType.Electricity)
                    electricityNeeded += (int)resource.amount;
                else
                    warehouseResources.Add(resource);
            }


            if (availableElectricity < electricityNeeded)
            {
                Console.WriteLine($"  [{name}] Не вистачає електрики: є {availableElectricity}, треба {electricityNeeded}");
                return;
            }

   
            if (!warehouse.HasResources(warehouseResources))
            {
                Console.WriteLine($"  [{name}] Не вистачає ресурсів на складі");
                return;
            }

         
            availableElectricity -= electricityNeeded;
            warehouse.RemoveResources(warehouseResources);

         
            List<ResourceAmount> produced = new List<ResourceAmount>();
            foreach (var resource in activeRecipe.receivedResourcesList)
            {
                double actualAmount = resource.amount * (efficiency / 100.0);
                produced.Add(new ResourceAmount(resource.resourceType, actualAmount));
                Console.WriteLine($"  [{name}] Вироблено: {actualAmount:F1} {resource.resourceType}");
            }
            warehouse.AddResources(produced);
        }
    }
}
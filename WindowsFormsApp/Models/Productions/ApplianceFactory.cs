using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class ApplianceFactory : Production
    {
        public ApplianceFactory(int id, string name) : base(id, name) { }

        public override ProductionType GetProductionType() => ProductionType.ApplianceFactory;

        public static ApplianceFactory Create(int id, string name)
        {
            ApplianceFactory production = new ApplianceFactory(id, name);
            Recipe recipe = new RecipeBuilder(id, "Виробництво чайників", 1)
                .Require(ResourceType.Electricity, 5)
                .Require(ResourceType.Iron, 2)
                .Require(ResourceType.Copper, 1)
                .Require(ResourceType.Plastic, 3)
                .Receive(ResourceType.Kettle, 1)
                .Build();
            production.recipeList.Add(recipe);
            production.SetActiveRecipe(recipe);
            return production;
        }
    }
}

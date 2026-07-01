using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class SteelPlant : Production
    {
        public SteelPlant(int id, string name) : base(id, name) { }

        public override ProductionType GetProductionType() => ProductionType.SteelPlant;

        public static SteelPlant Create(int id, string name)
        {
            SteelPlant production = new SteelPlant(id, name);
            Recipe recipe = new RecipeBuilder(id, "Залізна руда -> Метали", 1)
                .Require(ResourceType.IronOre, 10)
                .Require(ResourceType.Electricity, 10)
                .Receive(ResourceType.Iron, 8)
                .Receive(ResourceType.Copper, 1)
                .Receive(ResourceType.Lead, 1)
                .Build();
            production.recipeList.Add(recipe);
            production.SetActiveRecipe(recipe);
            return production;
        }
    }
}

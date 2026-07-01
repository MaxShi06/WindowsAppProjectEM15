using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class OilRefinery : Production
    {
        public OilRefinery(int id, string name) : base(id, name) { }

        public override ProductionType GetProductionType() => ProductionType.OilRefinery;

        public static OilRefinery Create(int id, string name)
        {
            OilRefinery production = new OilRefinery(id, name);
            Recipe recipe = new RecipeBuilder(id, "Нафта -> Паливо і Пластик", 1)
                .Require(ResourceType.Oil, 12)
                .Require(ResourceType.Electricity, 10)
                .Receive(ResourceType.Fuel, 8)
                .Receive(ResourceType.Plastic, 2)
                .Build();
            production.recipeList.Add(recipe);
            production.SetActiveRecipe(recipe);
            return production;
        }
    }
}

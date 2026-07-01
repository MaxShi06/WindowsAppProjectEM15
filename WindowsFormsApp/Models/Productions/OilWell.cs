using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class OilWell : Production
    {
        public OilWell(int id, string name) : base(id, name) { }

        public override ProductionType GetProductionType() => ProductionType.OilWell;

        public static OilWell Create(int id, string name)
        {
            OilWell production = new OilWell(id, name);
            Recipe recipe = new RecipeBuilder(id, "Видобуток нафти", 1)
                .Require(ResourceType.Electricity, 3)
                .Receive(ResourceType.Oil, 5)
                .Build();
            production.recipeList.Add(recipe);
            production.SetActiveRecipe(recipe);
            return production;
        }
    }
}

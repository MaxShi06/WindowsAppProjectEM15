using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class IronMine : Production
    {
        public IronMine(int id, string name) : base(id, name) { }

        public static IronMine Create(int id, string name)
        {
            IronMine production = new IronMine(id, name);
            Recipe recipe = new RecipeBuilder(id, "Видобуток залізної руди", 1)
                .Require(ResourceType.Electricity, 5)
                .Receive(ResourceType.IronOre, 10)
                .Build();
            production.recipeList.Add(recipe);
            production.SetActiveRecipe(recipe);
            return production;
        }
    }
}

using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class CoalMine : Production
    {
        public CoalMine(int id, string name) : base(id, name) { }


        public static CoalMine Create(int id, string name)
        {
            CoalMine production = new CoalMine(id, name);
            Recipe recipe = new RecipeBuilder(id, "Видобуток вугілля", 1)
                .Require(ResourceType.Electricity, 3)
                .Receive(ResourceType.Coal, 10)
                .Build();
            production.recipeList.Add(recipe);
            production.SetActiveRecipe(recipe);
            return production;
        }
    }
}

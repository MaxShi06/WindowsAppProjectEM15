using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class RecipeBuilder
    {
        private readonly Recipe recipe;

        public RecipeBuilder(int id, string name, int duration)
        {
            recipe = new Recipe(id, name, duration);
        }

        public RecipeBuilder Require(ResourceType type, double amount)
        {
            recipe.AddRequiredResource(type, amount);
            return this;
        }

        public RecipeBuilder Receive(ResourceType type, double amount)
        {
            recipe.AddReceivedResource(type, amount);
            return this;
        }

        public Recipe Build()
        {
            return recipe;
        }
    }
}

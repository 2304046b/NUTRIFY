namespace NUTRIFY.Components.Domain
{
    public class Recipe : BaseDomainModel
    {
        public int RecipeID { get; set; }
        public string? Name { get; set; } 
        public string? IngredientsList { get; set; } 
        public string? PreparationInstructions { get; set; } 
        public int TargetCalories { get; set; }

        public ICollection<Food> Foods { get; set; } = new List<Food>();
    }
}

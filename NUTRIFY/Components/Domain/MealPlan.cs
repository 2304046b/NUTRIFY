namespace NUTRIFY.Components.Domain
{
    public class MealPlan : BaseDomainModel
    {
        public int MealPlanID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string? Name { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DailyCalorieGoal { get; set; }

        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}

namespace NUTRIFY.Components.Domain
{
    public class User : BaseDomainModel
    {
        public int UserID { get; set; }
        public string? Name { get; set; } 
        public string? Email { get; set; } 
        public int Age { get; set; }
        public string? Gender { get; set; } 
        public string? DietaryPreferences { get; set; } 
        public string? HealthGoal { get; set; } 
        public string? Password { get; set; } 

        public ICollection<UserProgress> ProgressLogs { get; set; } = new List<UserProgress>();
        public ICollection<FoodLog> FoodLogs { get; set; } = new List<FoodLog>();
        public ICollection<MealPlan> MealPlans { get; set; } = new List<MealPlan>();
    }
}

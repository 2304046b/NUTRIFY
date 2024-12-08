namespace NUTRIFY.Components.Domain
{
    public class Goal : BaseDomainModel
    {
        public int GoalID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; } 
        public string? GoalType { get; set; }
        public DateTime TargetDate { get; set; }
        public int TargetCalories { get; set; }
    }
}

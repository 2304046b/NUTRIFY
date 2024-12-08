namespace NUTRIFY.Components.Domain
{
    public class UserProgress : BaseDomainModel
    {
        public int ProgressID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; } 
        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public string? NutrientsBreakdown { get; set; } 
    }
}

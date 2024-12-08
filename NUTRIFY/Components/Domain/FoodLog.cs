namespace NUTRIFY.Components.Domain
{
    public class FoodLog : BaseDomainModel
    {
        public int LogID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; } 
        public int FoodID { get; set; }
        public Food Food { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int TotalCalories { get; set; }
        public string? Emotion { get; set; }
        public double ServingSizeLogged { get; set; }
    }
}

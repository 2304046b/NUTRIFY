namespace NUTRIFY.Components.Domain
{
    public class EmotionalLog : BaseDomainModel
    {
        public int EmotionalLogID { get; set; }
        public DateTime Date { get; set; }
        public string? Emotion { get; set; }
        public string? Notes { get; set; } 
        public string? Context { get; set; } 
        public int Intensity { get; set; }
    }
}

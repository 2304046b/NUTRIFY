namespace NUTRIFY.Components.Domain
{
    public class Food : BaseDomainModel
    {
        public int FoodID { get; set; }
        public string Name { get; set; } 
        public string Barcode { get; set; } 
        public string Category { get; set; } 
        public double ServingSize { get; set; }
        public string Nutrients { get; set; }

        public ICollection<FoodLog> FoodLogs { get; set; } = new List<FoodLog>();
        public ICollection<Recipe> Recipes { get; set; } = [];
    }
}

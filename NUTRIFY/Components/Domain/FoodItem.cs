
namespace NUTRIFY.Components.Domain
{
    public class FoodItem : BaseDomainModel
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Description { get; set; }
        public string? Brand { get; set; }
        public string? Colour { get; set; } // Optional link to "Colour" if applicable
    }
}

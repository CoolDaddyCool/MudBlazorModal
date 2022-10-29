using System.ComponentModel.DataAnnotations;

namespace MudBlazorModal.Models
{
    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}

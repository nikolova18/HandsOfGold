namespace HandsOfGold.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = MinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(
            DescriptionMaxLength,
            MinimumLength = MinLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public bool IsPublic { get; set; }

        public int DealerId { get; set; }

        public Dealer Dealer { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}

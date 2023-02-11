using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web_API.Models
{
    public class Service
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }

        [ForeignKey("Category")]
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        [ForeignKey("CategoryType")]
        public int CategoryTypeId { get; set; }
        public CategoryType? CategoryType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VarChar { get; set; }
        public string VarText { get; set; }
        public double Fee { get; set; }




    }
}

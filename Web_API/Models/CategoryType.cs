using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web_API.Models
{
    public class CategoryType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string CatTypeName { get; set; }
        public string CatTypeDesc2 { get; set; }
        public string CatTypeDesc3 { get; set; }
        public string CatTypeDesc4 { get; set; }
    }
}

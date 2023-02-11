using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.Dto
{
    public class CategoryTypeDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public string CatTypeName { get; set; }
        public string CatTypeDesc2 { get; set; }
        public string CatTypeDesc3 { get; set; }
        public string CatTypeDesc4 { get; set; }
        public CompanyDTO Company { get; set; }
        public CategoryDTO Category { get; set; }
    }
}

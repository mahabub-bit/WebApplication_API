using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.Dto
{
    public class CategoryDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }

        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public CompanyDTO Company { get; set; }
    }
}

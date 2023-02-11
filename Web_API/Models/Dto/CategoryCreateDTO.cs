using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.Dto
{
    public class CategoryCreateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }

        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
    }
}

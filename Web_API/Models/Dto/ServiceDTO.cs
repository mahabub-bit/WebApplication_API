using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.Dto
{
    public class ServiceDTO
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int CategoryTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VarChar { get; set; }
        public string VarText { get; set; }
        public double Fee { get; set; }
    }
}

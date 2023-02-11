using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web_API.Models
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }

        [ForeignKey("Company")]
        [Required]
        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
    }
}

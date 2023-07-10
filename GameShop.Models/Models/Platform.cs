using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameShop.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Platform Name")]
        public string Name { get; set; }
		[DisplayName("Display Order")]
		public int DisplayOrder { get; set; }
    }
}

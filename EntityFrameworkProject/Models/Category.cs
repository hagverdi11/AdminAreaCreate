using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkProject.Models
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage ="Bosh Kecme")]
        [StringLength(10, ErrorMessage ="Qisalt biraz")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

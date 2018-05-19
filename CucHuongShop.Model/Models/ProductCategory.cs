using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CucHuongShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public string Discription { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        public string Image { get; set; }

        public bool? HotFlag { get; set; }

        public virtual IEnumerable<Product> MyProperty { get; set; }
    }
}
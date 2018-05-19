using CucHuongShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CucHuongShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public int CategoryID { get; set; }

        public string Image { get; set; }

        public XElement MoreImage { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? Promotion_Price { get; set; }

        public int? Warranty { get; set; }

        public string Discription { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory MyProperty { get; set; }
    }
}
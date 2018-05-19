using CucHuongShop.Model.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace CucHuongShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreateDate { get; set; }

        [MaxLength(100)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength]
        public string UpdateBy { get; set; }

        public string MetaKeywords { get; set; }
        public string MetaDecription { get; set; }

        public string Status { get; set; }
    }
}
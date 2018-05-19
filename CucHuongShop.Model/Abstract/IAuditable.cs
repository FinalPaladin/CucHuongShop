using System;

namespace CucHuongShop.Model.Models
{
    public interface IAuditable
    {
        DateTime CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }

        string MetaKeywords { get; set; }
        string MetaDecription { get; set; }

        string Status { get; set; }
    }
}
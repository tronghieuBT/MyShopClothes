using System;

namespace Shop_Clothes.Model.Models
{
    public interface IAuditable
    {
        DateTime? Createdate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}
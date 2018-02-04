﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Shop_Clothes.Model.Models
{
    public abstract class Auditable:IAuditable
    {
        public DateTime? Createdate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }
        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}
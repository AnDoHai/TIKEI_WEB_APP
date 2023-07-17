namespace Tikkei.Entity.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Image")]
    public partial class Image
    {
        public int ImageID { get; set; }

        public string ImageLink { get; set; }

        public int ProductDetailID { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(300)]
        public string CreatedBy { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }
    }
}

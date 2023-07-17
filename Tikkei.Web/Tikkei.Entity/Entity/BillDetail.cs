namespace Tikkei.Entity.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillDetail")]
    public partial class BillDetail
    {
        public int BillDetailID { get; set; }

        public int BillID { get; set; }

        public int Quanlity { get; set; }

        public float Total { get; set; }

        public int ProductDetailID { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(300)]
        public string CreatedBy { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }
    }
}

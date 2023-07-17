namespace Tikkei.Entity.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDetail")]
    public partial class ProductDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductDetail()
        {
            BillDetail = new HashSet<BillDetail>();
            Image = new HashSet<Image>();
        }

        public int ProductDetailID { get; set; }

        public int ProductID { get; set; }

        public int ColorID { get; set; }

        public int SizeID { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(300)]
        public string CreatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }

        public virtual Color Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Image { get; set; }

        public virtual Product Product { get; set; }

        public virtual Size Size { get; set; }
    }
}

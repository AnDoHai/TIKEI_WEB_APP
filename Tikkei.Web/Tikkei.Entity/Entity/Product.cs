namespace Tikkei.Entity.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductDetail = new HashSet<ProductDetail>();
        }

        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(300)]
        public string CreatedBy { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetail> ProductDetail { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tikkei.Entity.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public int ImageID { get; set; }
        public string ImageLink { get; set; }
        public int ProductDetailID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
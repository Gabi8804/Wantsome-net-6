//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreApp.DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategorySpecs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategorySpecs()
        {
            this.Prod_CatSpec = new HashSet<Prod_CatSpec>();
        }
    
        public int CategorySpecsId { get; set; }
        public int CategoryId { get; set; }
        public int SpecId { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Specs Specs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prod_CatSpec> Prod_CatSpec { get; set; }
    }
}

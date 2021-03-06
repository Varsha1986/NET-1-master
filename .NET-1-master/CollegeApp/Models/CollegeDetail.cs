//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollegeApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CollegeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CollegeDetail()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int CollegeID { get; set; }
        public string CollegeName { get; set; }
        public string CollegeAddress { get; set; }
        public string CollegePhone { get; set; }
        public string CollegeEmailID { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<int> CityID { get; set; }
    
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

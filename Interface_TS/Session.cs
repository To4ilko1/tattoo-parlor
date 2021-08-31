//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Interface_TS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Session
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Session()
        {
            this.Pay = new HashSet<Pay>();
            this.SessionServices = new HashSet<SessionServices>();
        }
    
        public long Id { get; set; }
        public Nullable<long> ClientID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<long> BranchID { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
        public Nullable<long> CountWorker { get; set; }
        public Nullable<bool> ReduceMaterial { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pay> Pay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionServices> SessionServices { get; set; }
    }
}
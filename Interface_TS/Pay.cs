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
    
    public partial class Pay
    {
        public long Id { get; set; }
        public Nullable<long> ClientID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<long> SessionID { get; set; }
        public Nullable<long> WorkerID { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual Session Session { get; set; }
    }
}

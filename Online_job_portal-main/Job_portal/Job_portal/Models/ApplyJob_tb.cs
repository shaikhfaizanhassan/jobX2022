
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Job_portal.Models
{

using System;
    using System.Collections.Generic;
    
public partial class ApplyJob_tb
{

    public int AJ_ID { get; set; }

    public Nullable<int> JobID { get; set; }

    public Nullable<int> Company_ID { get; set; }

    public Nullable<int> Job_seekerID { get; set; }

    public string Status { get; set; }

    public Nullable<System.DateTime> EntryDate { get; set; }



    public virtual Company_tb Company_tb { get; set; }

    public virtual jobseeker_tb jobseeker_tb { get; set; }

    public virtual PostJob_tb PostJob_tb { get; set; }

}

}

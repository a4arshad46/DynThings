
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DynThings.Data.Models
{

using System;
    using System.Collections.Generic;
    
public partial class EndPointType
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public EndPointType()
    {

        this.Endpoints = new HashSet<Endpoint>();

    }


    public long ID { get; set; }

    public string Title { get; set; }

    public string measurement { get; set; }

    public Nullable<long> TypeCategoryID { get; set; }

    public Nullable<long> IconID { get; set; }



    public virtual CssIcon CssIcon { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Endpoint> Endpoints { get; set; }

    public virtual EndPointTypeCategory EndPointTypeCategory { get; set; }

}

}

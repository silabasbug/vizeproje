//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace uyg01.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Siparisler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Siparisler()
        {
            this.Siparisler = new HashSet<Siparisler>();

        }

        public string siparisId { get; set; }
        public string siparisAdedi { get; set; }
        public string urunId { get; set; }
        public string musteriId { get; set; }
        public string teslimatAdresi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparisler { get; set; }
    }
}
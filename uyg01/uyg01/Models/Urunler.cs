﻿//------------------------------------------------------------------------------
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

    public partial class Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            this.Kategori = new HashSet<Kategori>();

        }

        public string urunId { get; set; }
        public string urunAdi { get; set; }
        public string urunKatAdi { get; set; }
        public string urunFiyati { get; set; }
        public string urunAdedi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage","CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection Kategori { get set;
    }

    }
}
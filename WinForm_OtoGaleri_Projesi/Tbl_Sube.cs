//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm_OtoGaleri_Projesi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Sube
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Sube()
        {
            this.Tbl_Arac = new HashSet<Tbl_Arac>();
            this.Tbl_Personel = new HashSet<Tbl_Personel>();
        }
    
        public int Sube_ID { get; set; }
        public string Sube_Adi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Arac> Tbl_Arac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Personel> Tbl_Personel { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaliSaha.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class KullaniciGirisTablo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KullaniciGirisTablo()
        {
            this.KiralanmışSahaTablo = new HashSet<KiralanmışSahaTablo>();
            this.OyuncuTablo = new HashSet<OyuncuTablo>();
            this.TakımTablo = new HashSet<TakımTablo>();
        }
    
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public Nullable<bool> KullaniciTipi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KiralanmışSahaTablo> KiralanmışSahaTablo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OyuncuTablo> OyuncuTablo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TakımTablo> TakımTablo { get; set; }
    }
}

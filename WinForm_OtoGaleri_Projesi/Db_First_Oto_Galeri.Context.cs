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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbFirst_OtoGaleriEntities : DbContext
    {
        public DbFirst_OtoGaleriEntities()
            : base("name=DbFirst_OtoGaleriEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Arac> Tbl_Arac { get; set; }
        public virtual DbSet<Tbl_Arac_Durumu> Tbl_Arac_Durumu { get; set; }
        public virtual DbSet<Tbl_İslemler> Tbl_İslemler { get; set; }
        public virtual DbSet<Tbl_Musteri> Tbl_Musteri { get; set; }
        public virtual DbSet<Tbl_Personel> Tbl_Personel { get; set; }
        public virtual DbSet<Tbl_Sube> Tbl_Sube { get; set; }
        public virtual DbSet<Kayit> Kayit { get; set; }
    }
}

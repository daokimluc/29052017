//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHO_DNXH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHO_DNXH()
        {
            this.KHO_CT_DNXH = new HashSet<KHO_CT_DNXH>();
        }
    
        public string SO_DN { get; set; }
        public string MA_DU_KIEN { get; set; }
        public System.DateTime NGAY_DN { get; set; }
        public string MA_KHACH_HANG { get; set; }
        public string MUC_DICH_SU_DUNG { get; set; }
        public string HINH_THUC_THANH_TOAN { get; set; }
        public Nullable<System.DateTime> NGAY_THANH_TOAN { get; set; }
        public string TRUC_THUOC { get; set; }
        public bool XUAT_HOA_DON { get; set; }
        public string NGUOI_DN { get; set; }
        public Nullable<bool> DA_DUYET { get; set; }
        public Nullable<bool> DA_HUY { get; set; }
        public Nullable<System.DateTime> NGAY_DUYET { get; set; }
        public string NGUOI_DUYET { get; set; }
        public Nullable<bool> DANG_XU_LY_GIU_HANG { get; set; }
        public Nullable<bool> DA_GIU_HANG { get; set; }
        public Nullable<bool> DA_XUAT_HANG { get; set; }
        public Nullable<bool> CHUA_XUAT_HANG { get; set; }
        public Nullable<bool> DANG_XUAT_HANG { get; set; }
        public Nullable<decimal> TONG_TIEN { get; set; }
    
        public virtual BH_DON_HANG_DU_KIEN BH_DON_HANG_DU_KIEN { get; set; }
        public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN1 { get; set; }
        public virtual KH KH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_DNXH> KHO_CT_DNXH { get; set; }
    }
}

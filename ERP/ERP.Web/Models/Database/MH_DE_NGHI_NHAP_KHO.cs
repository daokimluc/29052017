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
    
    public partial class MH_DE_NGHI_NHAP_KHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MH_DE_NGHI_NHAP_KHO()
        {
            this.MH_CT_DE_NGHI_NHAP_KHO = new HashSet<MH_CT_DE_NGHI_NHAP_KHO>();
        }
    
        public string MA_SO_DN { get; set; }
        public System.DateTime NGAY_DN { get; set; }
        public System.DateTime NGAY_VE_DU_KIEN { get; set; }
        public string NGUOI_DN { get; set; }
        public string MA_NCC { get; set; }
        public int ID_NGUOI_LIEN_HE { get; set; }
        public string MA_SO_PO { get; set; }
        public string HINH_THUC_VAN_CHUYEN { get; set; }
        public string HINH_THUC_THANH_TOAN { get; set; }
        public string THOI_HAN_THANH_TOAN { get; set; }
        public string DIEN_GIAI { get; set; }
        public decimal TONG_TIEN_HANG { get; set; }
        public decimal THUE_GTGT { get; set; }
        public decimal TIEN_THUE_VAT { get; set; }
        public decimal TONG_TIEN_DA_BAO_GOM_VAT { get; set; }
        public string TONG_TIEN_BANG_CHU { get; set; }
        public bool DA_NHAP_KHO { get; set; }
        public string PHIEU_NHAP_KHO { get; set; }
    
        public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG { get; set; }
        public virtual KHO_NHAP_KHO KHO_NHAP_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_CT_DE_NGHI_NHAP_KHO> MH_CT_DE_NGHI_NHAP_KHO { get; set; }
        public virtual NCC_LIEN_HE NCC_LIEN_HE { get; set; }
        public virtual NCC NCC { get; set; }
        public virtual MH_PO_MUA_HANG MH_PO_MUA_HANG { get; set; }
    }
}

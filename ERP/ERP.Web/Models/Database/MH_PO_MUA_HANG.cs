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
    
    public partial class MH_PO_MUA_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MH_PO_MUA_HANG()
        {
            this.MH_DE_NGHI_NHAP_KHO = new HashSet<MH_DE_NGHI_NHAP_KHO>();
            this.MH_PO_CT_MUA_HANG = new HashSet<MH_PO_CT_MUA_HANG>();
        }
    
        public string MA_SO_PO { get; set; }
        public System.DateTime NGAY_PO { get; set; }
        public string NGUOI_TAO { get; set; }
        public string NHA_CUNG_CAP { get; set; }
        public int NGUOI_LIEN_HE { get; set; }
        public string DIA_DIEM_GIAO_HANG { get; set; }
        public string HINH_THUC_VAN_CHUYEN { get; set; }
        public string HINH_THUC_THANH_TOAN { get; set; }
        public string THOI_HAN_THANH_TOAN { get; set; }
        public decimal TIEN_THUE_VAT { get; set; }
        public string TONG_TIEN_BANG_CHU { get; set; }
        public decimal TONG_TIEN_HANG { get; set; }
        public decimal TONG_TIEN_DA_BAO_GOM_VAT { get; set; }
        public decimal THUE_VAT { get; set; }
        public bool DA_NHAP_KHO { get; set; }
        public string MA_SO_NHAP_KHO { get; set; }
    
        public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG { get; set; }
        public virtual KHO_NHAP_KHO KHO_NHAP_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_DE_NGHI_NHAP_KHO> MH_DE_NGHI_NHAP_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_PO_CT_MUA_HANG> MH_PO_CT_MUA_HANG { get; set; }
        public virtual NCC_LIEN_HE NCC_LIEN_HE { get; set; }
        public virtual NCC NCC { get; set; }
    }
}

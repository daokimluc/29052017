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
    
    public partial class COMMENTS_CONG_NO_KH
    {
        public int ID { get; set; }
        public System.DateTime NGAY_COMMENTS { get; set; }
        public string NGUOI_COMMENTS { get; set; }
        public string NOI_DUNG_COMMENTS { get; set; }
        public string MA_KHACH_HANG { get; set; }
        public string TUAN_CONG_NO { get; set; }
    
        public virtual KH KH { get; set; }
        public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG { get; set; }
    }
}

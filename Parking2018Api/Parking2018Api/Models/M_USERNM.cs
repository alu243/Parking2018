using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 19 使用者資料檔
    /// </summary>
    public class M_USERNM : BaseColumn
    {
        /// <summary>
        /// 員工編號(unique)
        /// </summary>
        [StringLength(20)]
        [EF.UniqueIndex("UX_M_EMPY_NO")]
        public string EMPY_NO { get; set; }

        /// <summary>
        /// 使用者中文名稱
        /// </summary>
        [StringLength(50)]
        public string CNAME { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        [StringLength(40)]
        public string PSWD { get; set; }

        /// <summary>
        /// PDA Group 編號
        /// </summary>
        [StringLength(16)]
        public string PDA_NO { get; set; }
    }
}

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 擴充欄位用 TPC 方式建立
    /// CREATED, CREATEBY, LAST_MODIFIED, LAST_MODIFYBY
    /// 這個 class 不要加到 dbset 當中
    /// </summary>
    public class BaseColumn
    {
        /// <summary>
        /// 序號
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PKID { get; set; }


        /// <summary>
        /// 最後更新時間
        /// </summary>
        public DateTime LAST_MODIFIED { get; set; }

        /// <summary>
        /// 最後更新人員
        /// </summary>
        [StringLength(20)]
        public string LAST_MODIFYBY { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CREATED { get; set; }

        /// <summary>
        /// 建立人員
        /// </summary>
        [StringLength(20)]
        public string CREATEBY { get; set; }
    }
}

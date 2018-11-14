using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 17 PDA 系統參數設定	
    /// </summary>
    public class M_SYSTEM
    {
        /// <summary>
        /// 流水號(PKey)
        /// </summary>
        [Key]
        public long SEQ_NO { get; set; }

        /// <summary>
        /// 系統名稱設定
        /// </summary>
        [StringLength(50)]
        public string SYS_NAME { get; set; }

        /// <summary>
        /// 版本設定
        /// </summary>
        [StringLength(10)]
        public string VER_NO { get; set; }

        /// <summary>
        /// Barcode 印表明暗設定
        /// </summary>
        [StringLength(1)]
        public string PRT_CONTRAST { get; set; }

        /// <summary>
        /// Barcode 條碼窄碼 寬度設定
        /// </summary>
        [StringLength(1)]
        public string PRT_NB_WIDTH { get; set; }

        /// <summary>
        /// Barcode 條碼寬窄比設定
        /// </summary>
        [StringLength(1)]
        public string PRT_RATIO { get; set; }

        /// <summary>
        /// Barcode 印表速度設定
        /// </summary>
        [StringLength(1)]
        public string PRT_SPEED { get; set; }

        /// <summary>
        /// 超商代收代碼設定
        /// </summary>
        [StringLength(3)]
        public string RCV_ID { get; set; }

        /// <summary>
        /// 月票代碼設定
        /// </summary>
        [StringLength(2)]
        public string FREE_ID { get; set; }

        /// <summary>
        /// 大型格位代碼設定
        /// </summary>
        [StringLength(1)]
        public string LARGE_GIRD { get; set; }

        /// <summary>
        /// TIME SERVER IP ADDRESS
        /// </summary>
        [StringLength(50)]
        public string TIMESRV_IP { get; set; }

        /// <summary>
        /// TIME SERVER PORT NUMBER
        /// </summary>
        [StringLength(6)]
        public string TIMESRV_PORT { get; set; }

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

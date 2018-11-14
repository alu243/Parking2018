using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 24 PDA 參數設定檔		
    /// </summary>
    public class M_PDA_PARAMETER
    {
        /// <summary>
        /// 序號
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PKID { get; set; }

        /// <summary>
        /// 系統代碼(unique)
        /// </summary>
        [StringLength(10)]
        [EF.UniqueIndex("UX_M_PDA_PARAMETER", 1)]
        public string SYS_CODE { get; set; }

        /// <summary>
        /// 代碼(unique)
        /// </summary>
        [StringLength(2)]
        [EF.UniqueIndex("UX_M_PDA_PARAMETER", 2)]
        public string CODE { get; set; }

        /// <summary>
        /// 起始時間
        /// </summary>
        [StringLength(6)]
        public string STIME { get; set; }

        /// <summary>
        /// 截止時間
        /// </summary>
        [StringLength(6)]
        public string ETIME { get; set; }

        /// <summary>
        /// 免費分鐘數
        /// </summary>
        public int FREE_MINUTE { get; set; }

        /// <summary>
        /// 第一次計費分鐘數
        /// </summary>
        public int FREES_MINUTE { get; set; }

        /// <summary>
        /// 假日類別
        /// </summary>
        [StringLength(1)]
        public string HOLIDAY_TYPE { get; set; }

        /// <summary>
        /// 備用欄位 1
        /// </summary>
        public int I1 { get; set; }

        /// <summary>
        /// 備用欄位 2
        /// </summary>
        public int I2 { get; set; }

        /// <summary>
        /// 備用欄位 3
        /// </summary>
        public int I3 { get; set; }

        /// <summary>
        /// 備用欄位 4
        /// </summary>
        [StringLength(50)]
        public string C1 { get; set; }

        /// <summary>
        /// 備用欄位 5
        /// </summary>
        [StringLength(5)]
        public string C2 { get; set; }

        /// <summary>
        /// 備用欄位 6
        /// </summary>
        [StringLength(50)]
        public string C3 { get; set; }
    }
}

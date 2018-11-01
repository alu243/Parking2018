using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 22 身心障礙資料檔
    /// </summary>
    public class M_DEFECTIVE_CAR
    {
        /// <summary>
        /// 序號(PKey)
        /// </summary>
        [StringLength(11)]
        [Key]
        public string SEQ { get; set; }

        /// <summary>
        /// 證號
        /// </summary>
        [StringLength(20)]
        public string CERTIFIED_NO { get; set; }

        /// <summary>
        /// 車號
        /// </summary>
        [StringLength(10)]
        public string CAR_NO { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        [StringLength(8)]
        public string START_DATE { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        [StringLength(8)]
        public string END_DATE { get; set; }

        /// <summary>
        /// 縣市代碼
        /// </summary>
        [StringLength(2)]
        public string AREA_CODE { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CREATED { get; set; }
    }
}

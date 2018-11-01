using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 23 身障使用資源檔
    /// </summary>
    public class M_DEFECTIVE_USE
    {
        /// <summary>
        /// 停車單號(PKey)
        /// </summary>
        [StringLength(16)]
        [Key]
        public string BILL_NO { get; set; }

        /// <summary>
        /// 證號
        /// </summary>
        [StringLength(20)]
        public string CERTIFIED_NO { get; set; }

        /// <summary>
        /// 車號 1
        /// </summary>
        [StringLength(10)]
        public string CAR_NO1 { get; set; }

        /// <summary>
        /// 車號 2
        /// </summary>
        [StringLength(10)]
        public string CAR_NO2 { get; set; }

        /// <summary>
        /// 類別
        /// </summary>
        [StringLength(1)]
        public string USE_TYPE { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CREATED { get; set; }
    }
}

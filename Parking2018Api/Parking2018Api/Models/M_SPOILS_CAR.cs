using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 20 記錄遺失車輛記錄資料
    /// </summary>
    public class M_SPOILS_CAR
    {
        /// <summary>
        /// 車號(PKey)
        /// </summary>
        [StringLength(10)]
        [Key]
        public string CAR_NO { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CREATED { get; set; }
    }
}

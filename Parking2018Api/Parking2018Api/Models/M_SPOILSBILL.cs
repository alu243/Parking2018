using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 21 查贓記錄檔
    /// </summary>
    public class M_SPOILSBILL
    {
        /// <summary>
        /// 停車單號(PKey)
        /// </summary>
        [StringLength(16)]
        [Key]
        public string BILL_NO { get; set; }

        /// <summary>
        /// 車號
        /// </summary>
        [StringLength(10)]
        public string CAR_NO { get; set; }

        /// <summary>
        /// 查獲時間
        /// </summary>
        public DateTime QUERY_DATETIME { get; set; }
    }
}

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 3 巡場開單紀錄	
    /// </summary>
    public class M_BILL_REC : BaseColumn
    {
        /// <summary>
        /// 流水號(unique)
        /// </summary>
        [StringLength(3)]
        [EF.UniqueIndex("UX_M_BILL_REC", 1)]
        public string SEQ_NO { get; set; }

        /// <summary>
        /// 憑單單號(unique)
        /// </summary>
        [StringLength(16)]
        [EF.UniqueIndex("UX_M_BILL_REC", 2)]
        public string BILL_NO { get; set; }

        /// <summary>
        /// 離場時間
        /// </summary>
        [StringLength(4)]
        public string END_TIME { get; set; }
    }
}

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 18 月票車輛建檔
    /// </summary>
    public class M_TICKET : BaseColumn
    {
        /// <summary>
        /// 年度月份(unique)
        /// </summary>
        [StringLength(6)]
        [EF.UniqueIndex("UX_M_TICKET", 1)]
        public string YEAR { get; set; }

        /// <summary>
        /// 月次票證號(unique)
        /// </summary>
        [StringLength(8)]
        [EF.UniqueIndex("UX_M_TICKET", 2)]
        public string IDENTITY_NO { get; set; }

        /// <summary>
        /// 車牌號碼
        /// </summary>
        [StringLength(10)]
        public string CAR_NO { get; set; }


        /// <summary>
        /// 月票起始日
        /// </summary>
        [StringLength(8)]
        public string T_START_DATE { get; set; }


        /// <summary>
        /// 月票結束日
        /// </summary>
        [StringLength(8)]
        public string T_END_DATE { get; set; }

        /// <summary>
        /// 停車場(unique)
        /// </summary>
        [StringLength(6)]
        public string ROAD_NO { get; set; }
    }
}

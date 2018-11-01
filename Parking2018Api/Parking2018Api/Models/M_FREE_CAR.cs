using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 7 免責車輛建檔	
    /// </summary>
    public class M_FREE_CAR : BaseColumn
    {
        /// <summary>
        /// 年度(unique)
        /// </summary>
        [StringLength(4)]
        [EF.UniqueIndex("UX_M_FREE_CAR", 1)]
        public string YEAR { get; set; }

        /// <summary>
        /// 免責代碼(unique)
        /// </summary>
        [StringLength(2)]
        [EF.UniqueIndex("UX_M_FREE_CAR", 2)]
        public string FK_NO { get; set; }

        /// <summary>
        /// 停車證號(unique)
        /// </summary>
        [StringLength(9)]
        [EF.UniqueIndex("UX_M_FREE_CAR", 3)]
        public string PARK_NO { get; set; }

        /// <summary>
        /// 車種代瑪
        /// </summary>
        [StringLength(3)]
        public string KIND_NO { get; set; }

        /// <summary>
        /// 車牌號碼
        /// </summary>
        [StringLength(10)]
        public string CAR_NO { get; set; }

        /// <summary>
        /// 發照日期
        /// </summary>
        [StringLength(8)]
        public string P_START_DATE { get; set; }

        /// <summary>
        /// 有效日期
        /// </summary>
        [StringLength(8)]
        public string P_END_DATE { get; set; }
    }
}

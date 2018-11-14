using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 15 路段資料代碼檔
    /// </summary>
    public class M_ROAD : BaseColumn
    {
        /// <summary>
        /// 路段代碼(unique)
        /// </summary>
        [StringLength(6)]
        [EF.UniqueIndex("UX_M_ROAD")]
        public string ROAD_NO { get; set; }
        /// <summary>
        /// 路段名稱
        /// </summary>
        [StringLength(50)]
        public string ROAD_NAME { get; set; }

        /// <summary>
        /// 路段範圍
        /// </summary>
        [StringLength(80)]
        public string ROAD_RANGE { get; set; }
		
        /// <summary>
        /// 路段格數
        /// </summary>
        public int ROAD_NUM { get; set; }

        /// <summary>
        /// 路段類別
        /// </summary>
        [StringLength(1)]
        public string ROAD_TYPE { get; set; }

        /// <summary>
        /// 區別代碼
        /// </summary>
        [StringLength(3)]
        public string CELL_NO { get; set; }
    }
}

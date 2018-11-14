using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 12 PDA 每日排班檔
    /// </summary>
    public class M_PDA_CLASS_WEAVE : BaseColumn
    {
        /// <summary>
        /// 勤務日期(unique)
        /// </summary>
        [StringLength(8)]
        [EF.UniqueIndex("UX_M_PDA_CLASS_WEAVE", 1)]
        public string C_DATE { get; set; }

        /// <summary>
        /// 員工代碼(unique)
        /// </summary>
        [StringLength(20)]
        [EF.UniqueIndex("UX_M_PDA_CLASS_WEAVE", 2)]
        public string EMPY_NO { get; set; }

        /// <summary>
        /// 路段代碼(unique)
        /// </summary>
        [StringLength(6)]
        [EF.UniqueIndex("UX_M_PDA_CLASS_WEAVE", 3)]
        public string ROAD_NO { get; set; }

        /// <summary>
        /// 班別代碼(unique)
        /// </summary>
        [StringLength(1)]
        [EF.UniqueIndex("UX_M_PDA_CLASS_WEAVE", 4)]
        public string CLASS_NO { get; set; }
     
    }
}

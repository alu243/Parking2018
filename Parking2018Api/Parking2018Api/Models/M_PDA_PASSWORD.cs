using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 14 機動開單密碼檔
    /// </summary>
    public class M_PDA_PASSWORD : BaseColumn
    {
        /// <summary>
        /// 勤務日期(unique)
        /// </summary>
        [StringLength(8)]
        [EF.UniqueIndex("UX_M_PDA_PASSWORD")]
        public string C_DATE { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        [StringLength(40)]
        public string C_PASSWORD { get; set; }
    }
}

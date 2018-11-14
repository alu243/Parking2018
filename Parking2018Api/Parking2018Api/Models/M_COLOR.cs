using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 6 車輛顏色代碼檔	
    /// </summary>
    public class M_COLOR : BaseColumn
    {
        /// <summary>
        /// 顏色代碼(unique)
        /// </summary>
        [StringLength(4)]
        [EF.UniqueIndex("UX_M_COLOR")]
        public string CLR_NO { get; set; }

        /// <summary>
        /// 顏色名稱
        /// </summary>
        [StringLength(50)]
        public string CLR_NAME { get; set; }

    }
}

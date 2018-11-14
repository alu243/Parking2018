using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Parking2018Api.Models
{
    /// <summary>
    /// 1 繳費期限參數設定	
    /// </summary>
    public class M_AGECY_SYS_DATA : BaseColumn
    {
        /// <summary>
        /// 序號(unique)
        /// </summary>
        [StringLength(10)]
        [EF.UniqueIndex("UX_M_AGECY_SYS_DATA")]
        public string SEQ { get; set; }

        /// <summary>
        /// 催繳預定天數
        /// </summary>
        public int AGECY_DAY { get; set; }
    }
}

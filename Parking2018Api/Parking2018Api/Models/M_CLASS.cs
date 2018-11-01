using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 5 班別代碼檔	
    /// </summary>
    public class M_CLASS : BaseColumn
    {
        /// <summary>
        /// 班別代碼(unique)
        /// </summary>
        [StringLength(1)]
        [EF.UniqueIndex("UX_M_CLASS")]
        public string CLASS_NO { get; set; }

        /// <summary>
        /// 班別名稱
        /// </summary>
        [StringLength(50)]
        public string CLASS_NAME { get; set; }

        /// <summary>
        /// 上班時數
        /// </summary>
        public int WORK_TIME { get; set; }

        /// <summary>
        /// 開始時間
        /// </summary>
        [StringLength(4)]
        public int START_TIME { get; set; }

        /// <summary>
        /// 結束時間
        /// </summary>
        [StringLength(4)]
        public int END_TIME { get; set; }
    }
}

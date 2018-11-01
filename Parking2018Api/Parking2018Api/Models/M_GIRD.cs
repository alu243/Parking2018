using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 9 路段格位資料代碼檔	
    /// </summary>
    public class M_GIRD : BaseColumn
    {
        /// <summary>
        /// 格位代碼(unique)
        /// </summary>
        [StringLength(11)]
        [EF.UniqueIndex("UX_M_GIRD")]
        public string GIRD_NO { get; set; }

        /// <summary>
        /// 格位名稱
        /// </summary>
        [StringLength(50)]
        public string GIRD_NAME { get; set; }

        /// <summary>
        /// 格位種類代碼
        /// </summary>
        [StringLength(1)]
        public string GT_NO { get; set; }

        /// <summary>
        /// 計費種類
        /// </summary>
        [StringLength(1)]
        public string AMOUNT_TYPE { get; set; }

        /// <summary>
        /// 計費金額
        /// </summary>
        public int AMOUNT { get; set; }

        /// <summary>
        /// 累加金額
        /// </summary>
        public int G_LEVEL { get; set; }

        /// <summary>
        /// 最大時數
        /// </summary>
        public int MAX_HOUR { get; set; }

        /// <summary>
        /// 特殊費率
        /// </summary>
        public int SPEC_AMOUNT { get; set; }
    }
}

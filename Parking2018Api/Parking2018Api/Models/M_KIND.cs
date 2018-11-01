using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 11 車輛車種代碼檔	
    /// </summary>
    public class M_KIND : BaseColumn
    {
        /// <summary>
        /// 車種代碼(unique)
        /// </summary>
        [StringLength(3)]
        [EF.UniqueIndex("UX_M_KIND")]
        public string KIND_NO { get; set; }

        /// <summary>
        /// 車種名稱
        /// </summary>
        [StringLength(50)]
        public string KIND_NAME { get; set; }

        /// <summary>
        /// 計時收費金額
        /// </summary>
        public int AMOUNT1 { get; set; }

        /// <summary>
        /// 計次收費金額
        /// </summary>
        public int AMOUNT2 { get; set; }
    }
}

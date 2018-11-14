using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 10 格位種類代碼檔	
    /// </summary>
    public class M_GIRD_TYPE : BaseColumn
    {
        /// <summary>
        /// 格位種類代碼(unique)
        /// </summary>
        [StringLength(1)]
        [EF.UniqueIndex("UX_M_GIRD_TYPE")]
        public string GT_NO { get; set; }

        /// <summary>
        /// 格位種類名稱
        /// </summary>
        [StringLength(50)]
        public string GT_NAME { get; set; }

        /// <summary>
        /// 是否計費 Y/N
        /// </summary>
        [StringLength(1)]
        public string QTY_YN { get; set; }
    }
}

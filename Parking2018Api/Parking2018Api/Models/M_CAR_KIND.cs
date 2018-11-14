using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 4 車輛廠牌代碼檔	
    /// </summary>
    public class M_CAR_KIND : BaseColumn
    {
        /// <summary>
        /// 廠牌代碼(unique)
        /// </summary>
        [StringLength(3)]
        [EF.UniqueIndex("UX_M_CAR_KIND", 1)]
        public string CK_NO { get; set; }

        /// <summary>
        /// 廠牌名稱(unique)
        /// </summary>
        [StringLength(50)]
        [EF.UniqueIndex("UX_M_CAR_KIND", 2)]
        public string CK_NAME { get; set; }
    }
}

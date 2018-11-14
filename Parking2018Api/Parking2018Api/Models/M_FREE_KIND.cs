using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 8 免責車輛種類代碼檔	
    /// </summary>
    public class M_FREE_KIND : BaseColumn
    {
        /// <summary>
        /// 免責車輛種類代碼(unique)
        /// </summary>
        [StringLength(2)]
        [EF.UniqueIndex("UX_M_FREE_KIND")]
        public string FK_NO { get; set; }

        /// <summary>
        /// 免責車輛種類名稱
        /// </summary>
        [StringLength(50)]
        public string FK_NAME { get; set; }
    }
}

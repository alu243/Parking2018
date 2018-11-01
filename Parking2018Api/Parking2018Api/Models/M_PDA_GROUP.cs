using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 13 PDA 群組資料檔
    /// </summary>
    public class M_PDA_GROUP : BaseColumn
    {
        /// <summary>
        /// 設備編號(unique)
        /// </summary>
        [StringLength(16)]
        [EF.UniqueIndex("UX_M_PDA_GROUP", 1)]
        public string PDA_NO { get; set; }

        /// <summary>
        /// PDA 群組使用者(unique)
        /// </summary>
        [StringLength(20)]
        [EF.UniqueIndex("UX_M_PDA_GROUP", 2)]
        public string EMPY_NO { get; set; }
    }
}

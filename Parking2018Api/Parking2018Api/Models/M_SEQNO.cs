using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 16 PDA 單據號碼檔
    /// </summary>
    public class M_SEQNO : BaseColumn
    {
        /// <summary>
        /// PDA Group 編號(unique)
        /// </summary>
        [StringLength(16)]
        [EF.UniqueIndex("UX_M_SEQNO")]
        public string PDA_NO { get; set; }

        /// <summary>
        /// 目前 PDA 流水號
        /// </summary>
        [StringLength(20)]
        public string SEQ_NO { get; set; }
    }
}

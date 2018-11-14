using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking2018Api.Models
{
    /// <summary>
    /// 2 開單明細資料檔
    /// </summary>
    public class M_BILL : BaseColumn
    {
        //[Column(TypeName = "VARCHAR(1)")]
        /// <summary>
        /// 憑單種類(unique)
        /// </summary>
        [StringLength(1)]
        [EF.UniqueIndex("UX_M_BILL", 1)]
        public string BT_NO { get; set; }

        /// <summary>
        /// 憑單單號(unique)
        /// </summary>
        [StringLength(16)]
        [EF.UniqueIndex("UX_M_BILL", 2)]
        public string BILL_NO { get; set; }

        /// <summary>
        /// 開單人員
        /// </summary>
        [StringLength(20)]
        public string EMPY_NO { get; set; }

        /// <summary>
        /// PDA Group 編號
        /// </summary>
        [StringLength(16)]
        public string PDA_NO { get; set; }

        /// <summary>
        /// 輸入日期
        /// </summary>
        [StringLength(8)]
        public string KEY_DATE { get; set; }

        /// <summary>
        /// 開單日期
        /// </summary>
        [StringLength(8)]
        public string START_DATE { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        [StringLength(8)]
        public string END_DATE { get; set; }

        /// <summary>
        /// 車種
        /// </summary>
        public string CAR_NO { get; set; }
        [StringLength(3)]
        public string KIND_NO { get; set; }

        /// <summary>
        /// 顏色
        /// </summary>
        [StringLength(2)]
        public string CLR_NO { get; set; }

        /// <summary>
        /// 廠牌
        /// </summary>
        [StringLength(3)]
        public string CK_NO { get; set; }

        /// <summary>
        /// 路段代號
        /// </summary>
        [StringLength(6)]
        public string ROAD_NO { get; set; }

        /// <summary>
        /// 格位代碼
        /// </summary>
        [StringLength(11)]
        public string GIRD_NO { get; set; }

        /// <summary>
        /// 進場時間
        /// </summary>
        [StringLength(4)]
        public string START_TIME { get; set; }

        /// <summary>
        /// 離場時間
        /// </summary>
        [StringLength(4)]
        public string END_TIME { get; set; }

        /// <summary>
        /// 費率
        /// </summary>
        public int RATE { get; set; }

        /// <summary>
        /// 停車時數
        /// </summary>
        public int TIME_QTY { get; set; }

        /// <summary>
        /// 開單金額
        /// </summary>
        public int AMOUNT { get; set; }

        /// <summary>
        /// 免責車輛種類代碼
        /// </summary>
        [StringLength(2)]
        public string FK_NO { get; set; }

        /// <summary>
        /// PDA 是否列印 Y/N
        /// </summary>
        [StringLength(1)]
        public string PDA_PRINT { get; set; }

        /// <summary>
        /// PDA 列印次數
        /// </summary>
        public int PRINT_CNT { get; set; }

        /// <summary>
        /// 作廢 Y/N
        /// </summary>
        [StringLength(1)]
        public string CANCEL_YN { get; set; }

        /// <summary>
        /// 後台備份 Y/N
        /// </summary>
        [StringLength(1)]
        public string FINISH_YN { get; set; }


    }
}

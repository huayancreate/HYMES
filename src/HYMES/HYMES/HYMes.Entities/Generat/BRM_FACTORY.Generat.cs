using System;
using System.ComponentModel;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using System.Runtime.Serialization;
namespace HYMes.Entities
{
    [Serializable()]
    [Table("dbo.BRM_FACTORY", "BRM_FACTORY"), Index]
    partial class BRM_FACTORY : DataEntity<BRM_FACTORY>
    {
        public BRM_FACTORY()
        {

        }

         protected BRM_FACTORY(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
         //#region O/R映射成员

         ///// <summary>
         ///// FACTORY_KEY 。
         ///// </summary>
         //[Column("FACTORY_KEY", "FACTORY_KEY"), DataSize(7), PrimaryKey]
         //[DisplayName("FACTORY_KEY")]
         //public string FACTORY_KEY
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// FACTORY_SERIAL_KEY 。
         ///// </summary>
         //[Column("FACTORY_SERIAL_KEY", "FACTORY_SERIAL_KEY"), DataSize(10)]
         //[DisplayName("FACTORY_SERIAL_KEY")]
         //public int FACTORY_SERIAL_KEY
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// FACTORY_ID 。
         ///// </summary>
         //[Column("FACTORY_ID", "FACTORY_ID"), DataSize(40)]
         //[DisplayName("FACTORY_ID")]
         //public string FACTORY_ID
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// FACTORY_NAME 。
         ///// </summary>
         //[Column("FACTORY_NAME", "FACTORY_NAME"), DataSize(80)]
         //[DisplayName("FACTORY_NAME")]
         //public string FACTORY_NAME
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// FACTORY_DESC 。
         ///// </summary>
         //[Column("FACTORY_DESC", "FACTORY_DESC"), DataSize(200)]
         //[DisplayName("FACTORY_DESC")]
         //public string FACTORY_DESC
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// HOLD_FLG 。
         ///// </summary>
         //[Column("HOLD_FLG", "HOLD_FLG"), DataSize(1)]
         //[DisplayName("HOLD_FLG")]
         //public string HOLD_FLG
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// HOLD_DATE 。
         ///// </summary>
         //[Column("HOLD_DATE", "HOLD_DATE"), DataSize(19)]
         //[DisplayName("HOLD_DATE")]
         //public string HOLD_DATE
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// DAY_POINT 。
         ///// </summary>
         //[Column("DAY_POINT", "DAY_POINT"), DataSize(9)]
         //[DisplayName("DAY_POINT")]
         //public string DAY_POINT
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// WEEK_POINT 。
         ///// </summary>
         //[Column("WEEK_POINT", "WEEK_POINT"), DataSize(10)]
         //[DisplayName("WEEK_POINT")]
         //public int WEEK_POINT
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// ACTIVE 。
         ///// </summary>
         //[Column("ACTIVE", "ACTIVE"), DataSize(1)]
         //[DisplayName("ACTIVE")]
         //public string ACTIVE
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// TRX_DATE 。
         ///// </summary>
         //[Column("TRX_DATE", "TRX_DATE"), DataSize(19)]
         //[DisplayName("TRX_DATE")]
         //public string TRX_DATE
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// TRX_USER_KEY 。
         ///// </summary>
         //[Column("TRX_USER_KEY", "TRX_USER_KEY"), DataSize(7)]
         //[DisplayName("TRX_USER_KEY")]
         //public string TRX_USER_KEY
         //{
         //    get;
         //    set;
         //}

         ///// <summary>
         ///// TRX_USER_SERIAL_KEY 。
         ///// </summary>
         //[Column("TRX_USER_SERIAL_KEY", "TRX_USER_SERIAL_KEY"), DataSize(10)]
         //[DisplayName("TRX_USER_SERIAL_KEY")]
         //public int TRX_USER_SERIAL_KEY
         //{
         //    get;
         //    set;
         //}

         //#endregion
         #region O/R映射成员

         /// <summary>
         /// FACTORY_KEY 。
         /// </summary>
         [Column("FACTORY_KEY", "FACTORY_KEY"), PrimaryKey]
         public string FACTORY_KEY
         {
             get
             {
                 return this.GetValue<string>("FACTORY_KEY");
             }
             set
             {
                 this["FACTORY_KEY"] = value;
             }
         }

         /// <summary>
         /// FACTORY_SERIAL_KEY 。
         /// </summary>
         [Column("FACTORY_SERIAL_KEY", "FACTORY_SERIAL_KEY")]
         public int FACTORY_SERIAL_KEY
         {
             get
             {
                 return this.GetValue<int>("FACTORY_SERIAL_KEY");
             }
             set
             {
                 this["FACTORY_SERIAL_KEY"] = value;
             }
         }

         /// <summary>
         /// FACTORY_ID 。
         /// </summary>
         [Column("FACTORY_ID", "FACTORY_ID")]
         public string FACTORY_ID
         {
             get
             {
                 return this.GetValue<string>("FACTORY_ID");
             }
             set
             {
                 this["FACTORY_ID"] = value;
             }
         }

         /// <summary>
         /// FACTORY_NAME 。
         /// </summary>
         [Column("FACTORY_NAME", "FACTORY_NAME")]
         public string FACTORY_NAME
         {
             get
             {
                 return this.GetValue<string>("FACTORY_NAME");
             }
             set
             {
                 this["FACTORY_NAME"] = value;
             }
         }

         /// <summary>
         /// FACTORY_DESC 。
         /// </summary>
         [Column("FACTORY_DESC", "FACTORY_DESC")]
         public string FACTORY_DESC
         {
             get
             {
                 return this.GetValue<string>("FACTORY_DESC");
             }
             set
             {
                 this["FACTORY_DESC"] = value;
             }
         }

         /// <summary>
         /// HOLD_FLG 。
         /// </summary>
         [Column("HOLD_FLG", "HOLD_FLG")]
         public string HOLD_FLG
         {
             get
             {
                 return this.GetValue<string>("HOLD_FLG");
             }
             set
             {
                 this["HOLD_FLG"] = value;
             }
         }

         /// <summary>
         /// HOLD_DATE 。
         /// </summary>
         [Column("HOLD_DATE", "HOLD_DATE")]
         public string HOLD_DATE
         {
             get
             {
                 return this.GetValue<string>("HOLD_DATE");
             }
             set
             {
                 this["HOLD_DATE"] = value;
             }
         }

         /// <summary>
         /// DAY_POINT 。
         /// </summary>
         [Column("DAY_POINT", "DAY_POINT")]
         public string DAY_POINT
         {
             get
             {
                 return this.GetValue<string>("DAY_POINT");
             }
             set
             {
                 this["DAY_POINT"] = value;
             }
         }

         /// <summary>
         /// WEEK_POINT 。
         /// </summary>
         [Column("WEEK_POINT", "WEEK_POINT")]
         public String WEEK_POINT
         {
             get
             {
                 return this.GetValue<String>("WEEK_POINT");
             }
             set
             {
                 this["WEEK_POINT"] = value;
             }
         }

         /// <summary>
         /// ACTIVE 。
         /// </summary>
         [Column("ACTIVE", "ACTIVE")]
         public string ACTIVE
         {
             get
             {
                 return this.GetValue<string>("ACTIVE");
             }
             set
             {
                 this["ACTIVE"] = value;
             }
         }

         /// <summary>
         /// TRX_DATE 。
         /// </summary>
         [Column("TRX_DATE", "TRX_DATE")]
         public string TRX_DATE
         {
             get
             {
                 return this.GetValue<string>("TRX_DATE");
             }
             set
             {
                 this["TRX_DATE"] = value;
             }
         }

         /// <summary>
         /// TRX_LOGINID 。
         /// </summary>
         [Column("TRX_LOGINID", "TRX_LOGINID")]
         public string TRX_LOGINID
         {
             get
             {
                 return this.GetValue<string>("TRX_LOGINID");
             }
             set
             {
                 this["TRX_LOGINID"] = value;
             }
         }

         #endregion
    }
}

using CFBSM3Tech;
using PX.Data;
using PX.Objects;
using System;

namespace CFBSM3Tech
{
	public class CFSalesTargetsExt : PXCacheExtension<CFBSM3Tech.CFSalesTargets>
	{
        public class Const100 : Constant<decimal>
        {
            public Const100() : base(100) { }
        }

        #region UsrYTDSales
        [PXDBDecimal]
		[PXUIField(DisplayName="YTD Sales")]

		public virtual Decimal? UsrYTDSales { get; set; }
		public abstract class usrYTDSales : PX.Data.BQL.BqlDecimal.Field<usrYTDSales> { }
		#endregion

		#region UsrYTDBugMargin
		[PXDBDecimal]
		[PXUIField(DisplayName="YTD/Bug Margin")]
        [PXFormula(typeof(Mult<Const100,Div<CFSalesTargetsExt.usrYTDSales, CFSalesTargets.yearTotal>>))]
        
        public virtual Decimal? UsrYTDBugMargin { get; set; }
		public abstract class usrYTDBugMargin : PX.Data.BQL.BqlDecimal.Field<usrYTDBugMargin> { }
		#endregion
	}
}
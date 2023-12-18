using System;
namespace Mango.Web.Utility
{
	public class SD
	{
		public static string StrategyAPIBase { get; set; }
		public enum ApiType
		{
			GET,
			POST,
			PUT,
			DELETE
		}
		public SD()
		{
		}
	}
}
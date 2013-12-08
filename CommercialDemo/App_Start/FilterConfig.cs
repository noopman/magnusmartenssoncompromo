using System.Web.Mvc;

// ReSharper disable once CheckNamespace
namespace CommercialDemo
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
using HeyIdiot.ViewModels;
using HeyIdiot.Views;

namespace HeyIdiot.Helpers
{
  internal static class RouteHelper
  {
    public static string GetWordDetailRoute(string wordName)
    {
      var route = nameof(WordDetailPage);

      AppendQueryStringParam(ref route, nameof(WordDetailViewModel.Name), wordName);

      return route;
    }

    public static void AppendQueryStringParam(ref string route, string name, object value)
    {
      var qsSeparator = "?";
      if (route.Contains("?"))
      {
        qsSeparator = "&";
      }

      route += qsSeparator + name + "=" + value.ToString();
    }
  }
}

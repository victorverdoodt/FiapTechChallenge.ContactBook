using System.Web;

namespace FiapTechChallenge.ContactBook.Presentation.WebApp.Helpers
{
    public static class QueryStringBuilder
    {
        public static string ToQueryString(this object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             let value = p.GetValue(obj, null)
                             where value != null
                             select p.Name + "=" + HttpUtility.UrlEncode(value.ToString());

            return string.Join("&", properties.ToArray());
        }
    }
}

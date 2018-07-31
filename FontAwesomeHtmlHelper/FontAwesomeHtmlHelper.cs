using System.Web;
using System.Web.Mvc;

namespace FontAwesomeHtmlHelper
{
    public static class FontAwesomeHtmlHelper
    {
        public static IHtmlString FontAwesome(this HtmlHelper htmlHelper, Tag tag)
        {
            return new HtmlString(tag.ToString());
        }
    }
}

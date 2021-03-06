using System.Web;
using System.Web.Mvc;

namespace RestartMVC.CustomHtmlHelper
{
    public static class CustomHtmlHelper
    {
        //public static IHtmlString Image(this HtmlHelper helper, string src, string alt)
        //{
        //    // Build <img> tag
        //    TagBuilder tb = new TagBuilder("img");
        //    // Add "src" attribute
        //    tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
        //    // Add "alt" attribute
        //    tb.Attributes.Add("alt", alt);
        //    // return MvcHtmlString. This class implements IHtmlString
        //    // interface. IHtmlStrings will not be html encoded.
        //    return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        //}


        public static string Image(this HtmlHelper helper, string src, string alt)
        {
            // Build <img> tag
            TagBuilder tb = new TagBuilder("img");
            // Add "src" attribute
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            // Add "alt" attribute
            tb.Attributes.Add("alt", alt);
            // return MvcHtmlString. This class implements IHtmlString
            // interface. IHtmlStrings will not be html encoded.
            return  tb.ToString(TagRenderMode.SelfClosing);
        }
    }
}
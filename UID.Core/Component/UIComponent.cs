using System.Text;
using UID.Core.CSS;
using UID.Core.HTML;

namespace UID.Core.Component
{
    public class UIComponent
    {
        public List<HTMLElement> HeadHtmlElements { get; set; }
        public List<HTMLElement> BodyHtmlElements { get; set; }
        public List<CSSSelector> StyleSelectors { get; set; }

        public UIComponent()
        { }

        public Page GetPage()
        {
            var page = new Page();

            //foreach (var element in HeadHtmlElements)
            //{
            //    page.HtmlStringBuilder.AppendLine(element.ToString());
            //}

            foreach (var element in BodyHtmlElements)
            {
                page.HtmlStringBuilder.AppendLine(element.ToString());
            }

            foreach (var element in StyleSelectors)
            {
                page.CssStringBuilder.AppendLine(element.ToString());
            }

            return page;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

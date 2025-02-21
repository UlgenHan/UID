using System.Text;
using UID.Core.CSS;
using UID.Core.HTML;
using UID.Core.HTML.Tags.Sectioning;

namespace UID.Core.Component
{
    public class UIComponent
    {
        public List<HTMLElement> HeadHtmlElements { get; set; } = new List<HTMLElement>();
        public List<HTMLElement> BodyHtmlElements { get; set; } = new List<HTMLElement>();
        public List<CSSSelector> StyleSelectors { get; set; } = new List<CSSSelector>();

        public UIComponent()
        { }

        public Page GetPage()
        {
            var page = new Page();

            page.NameCss = "Style";
            page.ExtensionCss = "css";

            page.NameHtml = "index";
            page.ExtensionHtml = "html";

            ////foreach (var element in HeadHtmlElements)
            ////{
            ////    page.HtmlStringBuilder.AppendLine(element.ToString());
            ////}

            //foreach (var element in BodyHtmlElements)
            //{
            //    page.HtmlStringBuilder.AppendLine(element.ToString());
            //}

            var htmlElements = BuildHtmlString();

            page.HtmlStringBuilder.Append(htmlElements);

            foreach (var element in StyleSelectors)
            {
                page.CssStringBuilder.AppendLine(element.ToString());
            }

            return page;
        }


        private HTMLElement BuildHtmlString()
        {
            var html = new HtmlDocument();
            html.AddChildrenRange(HeadHtmlElements);
            html.AddChildrenRange(BodyHtmlElements);
            return html;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

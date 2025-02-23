using UID.Core.CSS;
using UID.Core.HTML;

namespace UID.Core.Component
{
    public class Page
    {
        public string NameHtml { get; set; }
        public string ExtensionHtml { get; set; } = "html";
        public string NameCss { get; set; }
        public string ExtensionCss { get; set; } = "css";

        public HTMLElement RootElement { get; set; }
        public List<CSSSelector> CssSelectors { get; set; } = new List<CSSSelector>();
    }

}

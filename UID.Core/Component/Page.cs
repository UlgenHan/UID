using System.Text;

namespace UID.Core.Component
{
    public class Page
    {
        public string NameHtml { get; set; }

        public string ExtensionHtml { get; set; }

        public string NameCss { get; set; }

        public string ExtensionCss { get; set; }
        public StringBuilder HtmlStringBuilder { get; set; } = new StringBuilder();

        public StringBuilder CssStringBuilder { get; set; } = new StringBuilder();
        public Page()
        {
            
        }
    }
}

using System.Text;

namespace UID.Core.Component
{
    public class Page
    {
        public StringBuilder HtmlStringBuilder { get; set; } = new StringBuilder();

        public StringBuilder CssStringBuilder { get; set; } = new StringBuilder();
        public Page()
        {
            
        }
    }
}

using UID.Core.HTML;

namespace UID.Core.Generator
{
    public class HTMLGenerator : IHTMLGenerator
    {
        public string Generate(HTMLElement element)
        {
            return element.ToString();
        }
    }

}

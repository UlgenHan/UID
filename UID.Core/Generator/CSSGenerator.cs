using System.Text;
using UID.Core.CSS;

namespace UID.Core.Generator
{
    public class CSSGenerator : ICSSGenerator
    {
        public string Generate(List<CSSSelector> selectors)
        {
            var sb = new StringBuilder();
            foreach (var selector in selectors)
            {
                sb.AppendLine(selector.ToString());
            }
            return sb.ToString();
        }
    }
}

using System.Text;

namespace UID.Core.CSS
{
    public class CSSSelector
    {
        public string SelectorName { get; set; }
        public List<CSSElement> Elements { get; set; }

        public CSSSelector(string selectorName)
        {
            SelectorName = selectorName;
            Elements = new List<CSSElement>();
        }

        public CSSSelector AddElement(CSSElement element)
        {
            Elements.Add(element);
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($".{SelectorName} {{");
            foreach (var element in Elements)
            {
                sb.AppendLine($"  {element.Key}: {element.Value};");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}

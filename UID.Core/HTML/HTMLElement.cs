using System.Runtime.CompilerServices;
using System.Text;
using UID.Core.CSS;

namespace UID.Core.HTML
{
    public abstract class HTMLElement
    {

        #region Fields

        public string TagName;

        public Dictionary<string, string> Attributes = new();

        private List<HTMLElement> Children = new();

        private List<CSSElement> Styles = new();

        private List<CSSSelector> Classes = new();

        private StringBuilder _stringBuilder = new StringBuilder();

        #endregion


        public HTMLElement(string tagName)
        {
            TagName = tagName;
        }

        public void AddChildren(HTMLElement child)
        {
            Children.Add(child);
        }

        public void AddStyle(CSSElement cssElement)
        {
            Styles.Add(cssElement);
        }

        public void AddClasses(CSSSelector selector) 
        { 
            Classes.Add(selector);
        }

        public void AddAttribute(string key, string value)
        {
            Attributes.Add(key, value);
        }

        public override string ToString()
        {
            _stringBuilder.Append($"<{TagName} ");

            BuildAttributeString();

            _stringBuilder.Append(">");

            BuildChildrenString();

            _stringBuilder.Append($"</{TagName}>");

            return _stringBuilder.ToString();
        }

        #region Stringify Methods
        private void BuildAttributeString()
        {
            BuildCustomAttributeString();
            BuildStyleString();
            BuildClassString();
        }

        private void BuildCustomAttributeString()
        {
            if (Attributes != null && Attributes.Count > 0)
            {
                foreach (var attr in Attributes)
                {
                    _stringBuilder.Append($"{attr.Key}=\"{attr.Value}\"");
                }
            }
        }

        private void BuildStyleString()
        {
            if (Styles != null && Styles.Count > 0)
            {
                _stringBuilder.Append(" style = \"");
                foreach (var style in Styles)
                {
                    _stringBuilder.Append($"{style.Key}:{style.Value};");
                }
                _stringBuilder.Append("\"");
            }
        }

        private void BuildClassString()
        {
            if(Classes != null && Classes.Count > 0)
            {
                _stringBuilder.Append(" class = \"");
                foreach (var c in Classes) 
                {
                    _stringBuilder.Append($"{c.SelectorName} ");
                }

                _stringBuilder.Append("\"");
            }
        }

        private void BuildChildrenString()
        {
            foreach (var child in Children)
            {
                _stringBuilder.Append($"{child.ToString()}");
            }
        }

        #endregion
    }
}

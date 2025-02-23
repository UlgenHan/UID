using UID.Core.CSS;

namespace UID.Core.HTML
{
    public class HTMLComposer
    {
        private HTMLElement _rootElement;

        public HTMLComposer(string rootTag) 
        { 
            _rootElement = new HTMLElement(rootTag);
        }
        public HTMLComposer AddChild(HTMLElement element)
        {
            _rootElement.AddChildren(element);
            return this;
        }

        public HTMLComposer AddStyle(CSSElement style)
        {
            _rootElement.AddStyle(style);
            return this;
        }

        public HTMLComposer AddClass(CSSSelector selector)
        {
            _rootElement.AddClasses(selector);
            return this;
        }

        public HTMLElement Build() => _rootElement;
    }
}

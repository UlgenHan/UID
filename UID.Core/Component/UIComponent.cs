using System.Text;
using UID.Core.CSS;
using UID.Core.HTML;
using UID.Core.HTML.Tags.Sectioning;

namespace UID.Core.Component
{
    public abstract class UIComponent
    {
        // The root HTML element for the component.
        public HTMLElement RootElement { get; protected set; }

        protected UIComponent(string rootTag)
        {
            // Initialize the root element using your HTMLTags or directly a string.
            RootElement = new HTMLElement(rootTag);
        }

        /// <summary>
        /// Adds a CSS class to the root element.
        /// </summary>
        public UIComponent AddClass(string className)
        {
            RootElement.AddClasses(new CSSSelector(className));
            return this;
        }

        /// <summary>
        /// Adds a child HTMLElement to the root element.
        /// </summary>
        public UIComponent AddChild(HTMLElement child)
        {
            RootElement.AddChildren(child);
            return this;
        }

        /// <summary>
        /// Adds multiple children to the root element.
        /// </summary>
        public UIComponent AddChildren(IEnumerable<HTMLElement> children)
        {
            RootElement.AddChildrenRange(children);
            return this;
        }

        /// <summary>
        /// Override this method to build your component's internal structure.
        /// </summary>
        public abstract void Build();

        /// <summary>
        /// Renders the component into its final HTML code.
        /// </summary>
        public string Render()
        {
            return RootElement.ToString();
        }
    }

}

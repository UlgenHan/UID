namespace UID.Core.HTML.Tags.Text
{
    public class HeadingElement : HTMLElement
    {
        public HeadingElement(int level) : base($"h{level}") { }
    }
}

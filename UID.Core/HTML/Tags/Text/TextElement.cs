namespace UID.Core.HTML.Tags.Text
{
    public class TextElement : HTMLElement
    {
        public TextElement(string text) : base("text")
        {
            AddChildren(new RawTextElement(text));
        }
    }
}

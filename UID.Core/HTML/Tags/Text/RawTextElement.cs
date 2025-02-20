namespace UID.Core.HTML.Tags.Text
{
    public class RawTextElement : HTMLElement
    {
        public string RawText { get; set; }
        public RawTextElement(string text) : base("")
        {
            RawText = text;
        }

        public override string ToString()
        {
            return $"{RawText}";
        }
    }
}

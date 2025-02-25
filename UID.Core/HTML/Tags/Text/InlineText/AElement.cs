namespace UID.Core.HTML.Tags.Text.InlineText
{
    public class AElement : HTMLElement
    {
        // Private fields
        private string _href;
        private string _target;
        private string _rel;
        private string _download;
        private string _type;
        private string _text;

        // Public properties
        public string Href
        {
            get => _href;
            set => _href = value;
        }

        public string Target
        {
            get => _target;
            set => _target = value;
        }

        public string Rel
        {
            get => _rel;
            set => _rel = value;
        }

        public string Download
        {
            get => _download;
            set => _download = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public string Text
        {
            get => _text;
            set => _text = value;
        }
        public AElement(string href,string text) : base(HTMLTags.A) 
        { 
            Text = text;
            Href = href;
        }

        public string Render()
        {
            var attributes = $"href=\"{_href}\"";

            if (!string.IsNullOrEmpty(_target))
                attributes += $" target=\"{_target}\"";

            if (!string.IsNullOrEmpty(_rel))
                attributes += $" rel=\"{_rel}\"";

            if (!string.IsNullOrEmpty(_download))
                attributes += $" download=\"{_download}\"";

            if (!string.IsNullOrEmpty(_type))
                attributes += $" type=\"{_type}\"";

            return $"<a {attributes}>{_text}</a>";
        }
    }
}

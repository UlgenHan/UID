using System.Text;

namespace UID.Core.CSS
{
    public abstract class CSSElement
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public CSSElement()
        {
            
        }

        public CSSElement SetStyle(string key, string value)
        {
            Key = key;
            Value = value;
            return this;
        }

        public override string ToString()
        {
            return $"{Key}:{Value};";
        }
    }
}

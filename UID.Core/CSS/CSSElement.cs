using System.Text;

namespace UID.Core.CSS
{
    public  class CSSElement : ICSSRenderAble
    {
        public string Key { get; }
        public string Value { get; }

        public CSSElement(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public virtual string Render()
        {
            return $"{Key}:{Value};";
        }
    }
}

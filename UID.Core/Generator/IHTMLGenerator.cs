using UID.Core.HTML;

namespace UID.Core.Generator
{
    public interface IHTMLGenerator
    {
        string Generate(HTMLElement element);
    }
}

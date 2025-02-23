using UID.Core.CSS;

namespace UID.Core.Generator
{
    public interface ICSSGenerator
    {
        string Generate(List<CSSSelector> selectors);
    }
}

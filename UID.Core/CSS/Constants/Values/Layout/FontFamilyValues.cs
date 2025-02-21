

namespace UID.Core.CSS.Constants.Values.Layout
{
    public static class FontFamilyValues
    {
        // Common generic font families.
        public const string Serif = "serif";
        public const string SansSerif = "sans-serif";
        public const string Monospace = "monospace";
        public const string Cursive = "cursive";
        public const string Fantasy = "fantasy";
        // You can add system-specific or custom font stacks as needed.
    }

    public static class FontSizeValues
    {
        // Common keyword sizes.
        public const string XXSmall = "xx-small";
        public const string XSmall = "x-small";
        public const string Small = "small";
        public const string Medium = "medium";
        public const string Large = "large";
        public const string XLarge = "x-large";
        public const string XXLarge = "xx-large";
        // You can add relative sizes such as "smaller" or "larger", or even default measurements.
    }

    public static class FontWeightValues
    {
        // Common font weights.
        public const string Normal = "normal";
        public const string Bold = "bold";
        public const string Bolder = "bolder";
        public const string Lighter = "lighter";
        // Numeric font weights as strings
        public const string Weight100 = "100";
        public const string Weight200 = "200";
        public const string Weight300 = "300";
        public const string Weight400 = "400"; // normal
        public const string Weight500 = "500";
        public const string Weight600 = "600";
        public const string Weight700 = "700"; // bold
        public const string Weight800 = "800";
        public const string Weight900 = "900";
    }

    public static class FontStyleValues
    {
        public const string Normal = "normal";
        public const string Italic = "italic";
        public const string Oblique = "oblique";
    }

    public static class LineHeightValues
    {
        public const string Normal = "normal";
        // You can add specific numeric or unit-based values if needed.
    }

    public static class LetterSpacingValues
    {
        public const string Normal = "normal";
        // Example default spacing, or you could include a unit-based value.
    }

    public static class TextAlignValues
    {
        public const string Left = "left";
        public const string Right = "right";
        public const string Center = "center";
        public const string Justify = "justify";
    }

    public static class TextDecorationValues
    {
        public const string None = "none";
        public const string Underline = "underline";
        public const string Overline = "overline";
        public const string LineThrough = "line-through";
        // You can combine values if needed, e.g., "underline overline"
    }

    public static class TextTransformValues
    {
        public const string None = "none";
        public const string Capitalize = "capitalize";
        public const string Uppercase = "uppercase";
        public const string Lowercase = "lowercase";
    }

    public static class TextShadowValues
    {
        // Since text-shadow takes measurements and color, a keyword value isn't common.
        // "none" is often used as a default.
        public const string None = "none";
    }

    public static class WhiteSpaceValues
    {
        public const string Normal = "normal";
        public const string Nowrap = "nowrap";
        public const string Pre = "pre";
        public const string PreWrap = "pre-wrap";
        public const string PreLine = "pre-line";
    }

    public static class ColorValues
    {
        // "inherit", "currentColor", and basic keywords are common.
        public const string Inherit = "inherit";
        public const string CurrentColor = "currentColor";
        // Some basic color keywords:
        public const string Black = "black";
        public const string White = "white";
        public const string Red = "red";
        public const string Blue = "blue";
        public const string Green = "green";
        // More colors can be added as needed.
    }

}

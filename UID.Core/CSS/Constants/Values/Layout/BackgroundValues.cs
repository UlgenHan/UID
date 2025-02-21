

namespace UID.Core.CSS.Constants.Values.Layout
{
    public static class BackgroundValues
    {
        // The background shorthand can combine several background properties.
        // These examples are meant as guidelines.
        public const string Transparent = "transparent";
        public const string None = "none";
        // You might combine other properties as needed.
    }

    public static class BackgroundColorValues
    {
        // Common background colors can include keywords or hex values.
        public const string Transparent = "transparent";
        public const string Inherit = "inherit";
        public const string Black = "black";
        public const string White = "white";
        // Add more colors or defaults as needed.
    }

    public static class BackgroundImageValues
    {
        // Background image often uses the url() syntax, but "none" is common.
        public const string None = "none";
        // You could include examples with URLs if appropriate.
        // e.g.: public const string SampleImage = "url('sample.jpg')";
    }

    public static class BackgroundPositionValues
    {
        // Common positions include keywords or measurements.
        public const string Center = "center";
        public const string TopLeft = "top left";
        public const string TopRight = "top right";
        public const string BottomLeft = "bottom left";
        public const string BottomRight = "bottom right";
        // You may include additional combinations as needed.
    }

    public static class BackgroundSizeValues
    {
        // Common background sizes.
        public const string Auto = "auto";
        public const string Cover = "cover";
        public const string Contain = "contain";
        // Specific dimensions can also be used.
    }

    public static class BackgroundRepeatValues
    {
        // Common repeat values.
        public const string Repeat = "repeat";
        public const string NoRepeat = "no-repeat";
        public const string RepeatX = "repeat-x";
        public const string RepeatY = "repeat-y";
    }

    public static class BackgroundAttachmentValues
    {
        // Background attachment options.
        public const string Scroll = "scroll";
        public const string Fixed = "fixed";
        public const string Local = "local";
    }

    public static class BackgroundClipValues
    {
        // Background clip values.
        public const string BorderBox = "border-box";
        public const string PaddingBox = "padding-box";
        public const string ContentBox = "content-box";
        // For text, sometimes "text" can be used (experimental).
    }

    public static class BackgroundOriginValues
    {
        // Background origin values.
        public const string BorderBox = "border-box";
        public const string PaddingBox = "padding-box";
        public const string ContentBox = "content-box";
    }

}

namespace UID.Core.CSS.Constants.Values.Layout
{
    public static class ListStyleValues
    {
        // The list-style shorthand property can combine type, position, and image.
        public const string None = "none";
        // You may create more combined shorthand examples if needed.
    }

    public static class ListStyleTypeValues
    {
        public const string None = "none";
        public const string Disc = "disc";
        public const string Circle = "circle";
        public const string Square = "square";
        public const string Decimal = "decimal";
        public const string LowerAlpha = "lower-alpha";
        public const string UpperAlpha = "upper-alpha";
        // Additional types can be added as required.
    }

    public static class ListStylePositionValues
    {
        public const string Inside = "inside";
        public const string Outside = "outside";
    }

    public static class ListStyleImageValues
    {
        // The image value generally uses a url(), with "none" as the default.
        public const string None = "none";
        // For example:
        // public const string CustomImage = "url('path/to/image.png')";
    }

    public static class BorderCollapseValues
    {
        // Border collapse for tables accepts either separate or collapse.
        public const string Separate = "separate";
        public const string Collapse = "collapse";
    }

    public static class BorderSpacingValues
    {
        // Border-spacing accepts lengths; "0" is often a default.
        public const string Zero = "0";
        // You might add other common spacing values as needed.
    }

    public static class TableLayoutValues
    {
        // Common table layout values.
        public const string Auto = "auto";
        public const string Fixed = "fixed";
    }

    public static class CaptionSideValues
    {
        // Caption-side defines the position of table captions.
        public const string Top = "top";
        public const string Bottom = "bottom";
        public const string Left = "left";
        public const string Right = "right";
        // "top" is the default in most browsers.
    }

}

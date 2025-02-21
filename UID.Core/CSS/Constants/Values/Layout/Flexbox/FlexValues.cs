
namespace UID.Core.CSS.Constants.Values.Layout.Flexbox
{
    public static class FlexValues
    {
        // The flex property is a shorthand and can take various forms,
        // so you might decide on specific common values.
        public const string Initial = "initial";
        public const string Auto = "auto";
        // You can add more based on your use case.
    }

    public static class FlexDirectionValues
    {
        public const string Row = "row";
        public const string RowReverse = "row-reverse";
        public const string Column = "column";
        public const string ColumnReverse = "column-reverse";
    }

    public static class FlexWrapValues
    {
        public const string Nowrap = "nowrap";
        public const string Wrap = "wrap";
        public const string WrapReverse = "wrap-reverse";
    }

    public static class JustifyContentValues
    {
        public const string FlexStart = "flex-start";
        public const string FlexEnd = "flex-end";
        public const string Center = "center";
        public const string SpaceBetween = "space-between";
        public const string SpaceAround = "space-around";
        public const string SpaceEvenly = "space-evenly";
    }

    public static class AlignItemsValues
    {
        public const string Stretch = "stretch";
        public const string FlexStart = "flex-start";
        public const string FlexEnd = "flex-end";
        public const string Center = "center";
        public const string Baseline = "baseline";
    }

    public static class AlignContentValues
    {
        public const string Stretch = "stretch";
        public const string FlexStart = "flex-start";
        public const string FlexEnd = "flex-end";
        public const string Center = "center";
        public const string SpaceBetween = "space-between";
        public const string SpaceAround = "space-around";
    }

    public static class OrderValues
    {
        // Order accepts numeric values. "0" is the default, but you could include some common ones.
        public const string Zero = "0";
        // If needed, add others or helper methods.
    }

    public static class FlexGrowValues
    {
        // Flex grow is typically a number, "0" is default.
        public const string Zero = "0";
        public const string One = "1";
    }

    public static class FlexShrinkValues
    {
        // Flex shrink is also typically numeric.
        public const string Zero = "0";
        public const string One = "1";
    }

    public static class FlexBasisValues
    {
        // Common flex-basis values can include "auto" and specific measurements.
        public const string Auto = "auto";
        // You can add additional predefined measurements if needed.
    }

}

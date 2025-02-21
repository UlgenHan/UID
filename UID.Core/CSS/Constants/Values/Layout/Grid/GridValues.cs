

namespace UID.Core.CSS.Constants.Values.Layout.Grid
{
    public static class GridTemplateColumnsValues
    {
        // Common shorthand examples; typically you might use a combination of measurements
        public const string Auto = "auto";
        public const string None = "none";
        // Example for two equal columns
        public const string TwoEqualColumns = "1fr 1fr";
        // You could add additional combinations if needed.
    }

    public static class GridTemplateRowsValues
    {
        public const string Auto = "auto";
        public const string None = "none";
        // Example for two equal rows
        public const string TwoEqualRows = "1fr 1fr";
    }

    public static class GridTemplateAreasValues
    {
        // Predefining areas is more contextual; here are a few examples
        // For a simple layout with a header, content and footer.
        public const string BasicLayout = "\"header header\" \"content sidebar\" \"footer footer\"";
        // You can add other common grid area layouts as needed.
    }

    public static class GridGapValues
    {
        // Grid gap (or gap) can be set to specific measurements or common keywords.
        public const string None = "0";
        // A common default gap value.
        public const string Default = "10px";
    }

    public static class GridRowValues
    {
        // Grid row can be defined with line numbers or names.
        public const string Auto = "auto";
        // You can extend this to include common numeric values if desired.
    }

    public static class GridColumnValues
    {
        public const string Auto = "auto";
        // As with rows, you can add more numeric or named examples.
    }

    public static class GridAutoRowsValues
    {
        public const string Auto = "auto";
        // A common fallback for auto rows.
        public const string MinContent = "min-content";
        public const string MaxContent = "max-content";
    }

    public static class GridAutoColumnsValues
    {
        public const string Auto = "auto";
        public const string MinContent = "min-content";
        public const string MaxContent = "max-content";
    }

    public static class GridAutoFlowValues
    {
        public const string Row = "row";
        public const string Column = "column";
        public const string Dense = "dense";
        // Combining row with dense isn't uncommon.
        public const string RowDense = "row dense";
        public const string ColumnDense = "column dense";
    }

}

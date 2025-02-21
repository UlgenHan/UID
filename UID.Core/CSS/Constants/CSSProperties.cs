namespace UID.Core.CSS.Constants
{
    public static class CSSProperties
    {
        // Layout & Box Model
        public const string Display = "display";
        public const string BoxSizing = "box-sizing";
        public const string Width = "width";
        public const string Height = "height";
        public const string MinWidth = "min-width";
        public const string MinHeight = "min-height";
        public const string MaxWidth = "max-width";
        public const string MaxHeight = "max-height";
        public const string Margin = "margin";
        public const string MarginTop = "margin-top";
        public const string MarginRight = "margin-right";
        public const string MarginBottom = "margin-bottom";
        public const string MarginLeft = "margin-left";
        public const string Padding = "padding";
        public const string PaddingTop = "padding-top";
        public const string PaddingRight = "padding-right";
        public const string PaddingBottom = "padding-bottom";
        public const string PaddingLeft = "padding-left";
        public const string Border = "border";
        public const string BorderWidth = "border-width";
        public const string BorderStyle = "border-style";
        public const string BorderColor = "border-color";
        public const string BorderRadius = "border-radius";
        public const string Outline = "outline";
        public const string OutlineWidth = "outline-width";
        public const string OutlineStyle = "outline-style";
        public const string OutlineColor = "outline-color";
        public const string Overflow = "overflow";
        public const string OverflowX = "overflow-x";
        public const string OverflowY = "overflow-y";
        public const string Clip = "clip";

        // Positioning
        public const string Position = "position";
        public const string Top = "top";
        public const string Right = "right";
        public const string Bottom = "bottom";
        public const string Left = "left";
        public const string ZIndex = "z-index";

        // Flexbox
        public const string Flex = "flex";
        public const string FlexDirection = "flex-direction";
        public const string FlexWrap = "flex-wrap";
        public const string JustifyContent = "justify-content";
        public const string AlignItems = "align-items";
        public const string AlignContent = "align-content";
        public const string Order = "order";
        public const string FlexGrow = "flex-grow";
        public const string FlexShrink = "flex-shrink";
        public const string FlexBasis = "flex-basis";

        // Grid
        public const string GridTemplateColumns = "grid-template-columns";
        public const string GridTemplateRows = "grid-template-rows";
        public const string GridTemplateAreas = "grid-template-areas";
        public const string GridGap = "grid-gap";
        public const string GridRow = "grid-row";
        public const string GridColumn = "grid-column";
        public const string GridAutoRows = "grid-auto-rows";
        public const string GridAutoColumns = "grid-auto-columns";
        public const string GridAutoFlow = "grid-auto-flow";

        // Typography
        public const string FontFamily = "font-family";
        public const string FontSize = "font-size";
        public const string FontWeight = "font-weight";
        public const string FontStyle = "font-style";
        public const string LineHeight = "line-height";
        public const string LetterSpacing = "letter-spacing";
        public const string TextAlign = "text-align";
        public const string TextDecoration = "text-decoration";
        public const string TextTransform = "text-transform";
        public const string TextShadow = "text-shadow";
        public const string WhiteSpace = "white-space";
        public const string Color = "color";

        // Background
        public const string Background = "background";
        public const string BackgroundColor = "background-color";
        public const string BackgroundImage = "background-image";
        public const string BackgroundPosition = "background-position";
        public const string BackgroundSize = "background-size";
        public const string BackgroundRepeat = "background-repeat";
        public const string BackgroundAttachment = "background-attachment";
        public const string BackgroundClip = "background-clip";
        public const string BackgroundOrigin = "background-origin";

        // Effects & Transitions
        public const string BoxShadow = "box-shadow";
        public const string Opacity = "opacity";
        public const string Transition = "transition";
        public const string TransitionProperty = "transition-property";
        public const string TransitionDuration = "transition-duration";
        public const string TransitionTimingFunction = "transition-timing-function";
        public const string TransitionDelay = "transition-delay";
        public const string Animation = "animation";
        public const string AnimationName = "animation-name";
        public const string AnimationDuration = "animation-duration";
        public const string AnimationTimingFunction = "animation-timing-function";
        public const string AnimationDelay = "animation-delay";
        public const string AnimationIterationCount = "animation-iteration-count";
        public const string AnimationDirection = "animation-direction";
        public const string Transform = "transform";
        public const string TransformOrigin = "transform-origin";

        // Lists & Tables
        public const string ListStyle = "list-style";
        public const string ListStyleType = "list-style-type";
        public const string ListStylePosition = "list-style-position";
        public const string ListStyleImage = "list-style-image";
        public const string BorderCollapse = "border-collapse";
        public const string BorderSpacing = "border-spacing";
        public const string TableLayout = "table-layout";
        public const string CaptionSide = "caption-side";

        // Miscellaneous
        public const string Cursor = "cursor";
        public const string Visibility = "visibility";
        public const string Filter = "filter";
        public const string ClipPath = "clip-path";

        // Responsive & Media Queries (properties used in media queries)
        public const string Orientation = "orientation";
        public const string AspectRatio = "aspect-ratio";
        public const string Resolution = "resolution";

        // Custom Properties / CSS Variables (prefix with -- when using)
        // These are not standard properties but serve as a convention.
        // e.g., public const string MainColor = "--main-color";

        // Advanced / Experimental
        public const string MixBlendMode = "mix-blend-mode";
        public const string Isolation = "isolation";
        public const string FilterFunction = "filter"; // Sometimes used for CSS filter functions
    }

}

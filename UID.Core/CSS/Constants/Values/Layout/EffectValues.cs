

namespace UID.Core.CSS.Constants.Values.Layout
{
    public static class BoxShadowValues
    {
        // Box-shadow often uses a comma-separated list of shadows,
        // "none" is a common default.
        public const string None = "none";
        // Example of a simple shadow (offsetX offsetY blur color)
        public const string Default = "2px 2px 5px rgba(0,0,0,0.3)";
    }

    public static class OpacityValues
    {
        // Opacity accepts a numeric value between 0 and 1.
        public const string Opaque = "1";
        public const string SemiTransparent = "0.5";
        public const string Transparent = "0";
    }

    public static class TransitionValues
    {
        // Transition is a shorthand property combining several values.
        // "none" is often used as a default.
        public const string None = "none";
        // You might include a sample transition if desired.
        public const string Default = "all 0.3s ease";
    }

    public static class TransitionPropertyValues
    {
        // Common transition properties.
        public const string All = "all";
        public const string Opacity = "opacity";
        public const string Transform = "transform";
        // Add others as needed.
    }

    public static class TransitionDurationValues
    {
        // Duration values are typically given in seconds or milliseconds.
        public const string Default = "0.3s";
        public const string Instant = "0s";
    }

    public static class TransitionTimingFunctionValues
    {
        public const string Ease = "ease";
        public const string Linear = "linear";
        public const string EaseIn = "ease-in";
        public const string EaseOut = "ease-out";
        public const string EaseInOut = "ease-in-out";
    }

    public static class TransitionDelayValues
    {
        // Delay values are typically given in seconds or milliseconds.
        public const string None = "0s";
    }

    public static class AnimationValues
    {
        // Animation is a shorthand property.
        public const string None = "none";
        // A default example could be provided if needed.
        // public const string Default = "[animation values]";
    }

    public static class AnimationNameValues
    {
        // Animation names typically correspond to keyframes defined elsewhere.
        public const string None = "none";
        // You can add predefined animation names if you have a naming convention.
    }

    public static class AnimationDurationValues
    {
        // Duration for animations, usually in seconds or milliseconds.
        public const string Default = "1s";
    }

    public static class AnimationTimingFunctionValues
    {
        // Similar to transition timing functions.
        public const string Ease = "ease";
        public const string Linear = "linear";
        public const string EaseIn = "ease-in";
        public const string EaseOut = "ease-out";
        public const string EaseInOut = "ease-in-out";
    }

    public static class AnimationDelayValues
    {
        public const string None = "0s";
    }

    public static class AnimationIterationCountValues
    {
        // Animation iteration count accepts a number or "infinite".
        public const string Once = "1";
        public const string Infinite = "infinite";
    }

    public static class AnimationDirectionValues
    {
        public const string Normal = "normal";
        public const string Reverse = "reverse";
        public const string Alternate = "alternate";
        public const string AlternateReverse = "alternate-reverse";
    }

    public static class TransformValues
    {
        // Transform accepts multiple functions, "none" is the default.
        public const string None = "none";
        // You can add a sample value such as:
        public const string ScaleUp = "scale(1.1)";
    }

    public static class TransformOriginValues
    {
        // Transform origin accepts positions (keywords, percentages, or lengths).
        public const string Center = "center";
        public const string TopLeft = "top left";
        public const string BottomRight = "bottom right";
    }

}

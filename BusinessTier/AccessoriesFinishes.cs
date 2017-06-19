namespace BusinessTier
{
    /// <summary>
    /// enumerations which defines values for Accessories
    /// </summary>
    public enum Accessories
    {
        None,
        StereSystem,
        LeatherInterior,
        StereoAndLeather,
        ComputerNavigation,
        StereoAndNavigation,
        LeatherAndNavigation,
        All
    }

    /// <summary>
    /// enumerations which defines values for ExteriorFinish
    /// </summary>
    public enum ExteriorFinish
    {
        None,
        Standard,
        Pearlized,
        Custom
    }

    /// <summary>
    /// static class defines constant cost values for each of the accessory types
    /// </summary>
    public static class Accessory
    {
        public const decimal NONE = 0,
                STEREO_SYSTEM = 505.05m,
                LEATHER_INTERIOR = 1010.10m,
                COMPUTER_NAVIGATION = 1515.15m;
    }

    /// <summary>
    /// static class defines constant cost values for each of the exterior finish types.
    /// </summary>
    public static class Finish
    {
        public const decimal NONE = 0,
                STANDARD = 0,
                PEARLIZED = 404.04m,
                CUSTOM = 606.06m;
    }

    /// <summary>
    /// enumerations which defines values for CostType
    /// </summary>
    public enum CostType
    {
        Labour,
        Part,
        Material
    }
}
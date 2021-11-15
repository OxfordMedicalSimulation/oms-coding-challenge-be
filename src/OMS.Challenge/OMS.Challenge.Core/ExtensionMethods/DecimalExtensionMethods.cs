namespace OMS.Challenge.Core.ExtensionMethods
{
    public static class DecimalExtensionMethods
    {
        /// <summary>
        /// Converts a distance recorded in miles into km (we store all distances in km but our friends in the states use miles).
        /// </summary>
        /// <param name="miles">The distance in miles</param>
        /// <returns></returns>
        public static decimal ConvertMilesToKm(this decimal miles)
        {
            return miles / 5 * 8;
        }
    }
}

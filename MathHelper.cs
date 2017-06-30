using System;

namespace Helper
{
    /// <summary>
    /// Contains math methods which I found useful during my work
    /// </summary>
    public static class MathHelper : Object
    {
        /// <summary>
        /// Converts angle from degrees to radians
        /// </summary>
        /// <returns>Angle in radians</returns>
        public static double ToRadians(double degrees)
        {
            return (Math.PI / 180) * degrees;
        }

        /// <summary>
        /// Returns sinus of specified angle (in degrees)
        /// </summary>
        public static double Sin(double deg)
        {
            return Math.Sin(ToRadians(deg));
        }
    }
}

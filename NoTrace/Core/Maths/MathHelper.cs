using System;

namespace NoTrace.Core.Maths
{
    /// <summary>
    /// Contains convenience methods, which are used often.
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Smallest necessary number.
        /// </summary>
        public const float Theta = 0.001f;

        /// <summary>
        /// Float constant of PI
        /// </summary>
        public const float PI = ( float ) Math.PI;
        
        /// <summary>
        /// Flaot constant of one over PI
        /// </summary>
        public const float OneOverPI = ( float ) ( 1.0 / Math.PI );

        /// <summary>
        /// Float constant of one over two PI
        /// </summary>
        public const float OneOverTwoPI = ( float ) ( 1.0 / ( 2.0 * Math.PI ) );

        /// <summary>
        /// Converts the input angle into radians.
        /// </summary>
        /// <param name="Angle"></param>
        /// <param name="InRadians"></param>
        /// <returns><paramref name="Angle"/> in radians, or just <paramref name="Angle"/> if <paramref name="InRadians"/> is true.</returns>
        public static float GetRadians( float Angle, bool InRadians = true )
        {
            return InRadians ? Angle : DegreesToRadians( Angle );
        }

        /// <summary>
        /// Converts an angle in radians into the same angle represented in degrees.
        /// </summary>
        /// <param name="Radians"></param>
        /// <returns></returns>
        public static float RadiansToDegrees( float Radians )
        {
            return Radians * ( 180.0f / PI );
        }

        /// <summary>
        /// Converts an angle in degrees into the same angle represented in radians.
        /// </summary>
        /// <param name="Degrees"></param>
        /// <returns></returns>
        public static float DegreesToRadians( float Degrees )
        {
            return Degrees * ( PI / 180.0f );
        }

        /// <summary>
        /// Calculates the float cosine of a given angle.
        /// </summary>
        /// <param name="Angle"></param>
        /// <param name="Radians"></param>
        /// <returns></returns>
        public static float Cos( float Angle, bool Radians = true )
        {
            return ( float ) Math.Cos( GetRadians( Angle, Radians ) );
        }

        /// <summary>
        /// Calculates the float sine of a given angle.
        /// </summary>
        /// <param name="Angle"></param>
        /// <param name="Radians"></param>
        /// <returns></returns>
        public static float Sin( float Angle, bool Radians = true )
        {
            return ( float ) Math.Sin( GetRadians( Angle, Radians ) );
        }

        /// <summary>
        /// Calculates the float tan of a given angle.
        /// </summary>
        /// <param name="Angle"></param>
        /// <param name="Radians"></param>
        /// <returns></returns>
        public static float Tan( float Angle, bool Radians = true )
        {
            return ( float ) Math.Tan( GetRadians( Angle, Radians ) );
        }

        /// <summary>
        /// Calculates the float atan of a given angle.
        /// </summary>
        /// <param name="Angle"></param>
        /// <param name="Radians"></param>
        /// <returns></returns>
        public static float ATan( float Angle, bool Radians = true )
        {
            return ( float ) Math.Atan( GetRadians( Angle, Radians ) );
        }
    }
}

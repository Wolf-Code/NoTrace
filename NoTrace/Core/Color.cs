
namespace NoTrace.Core
{
    /// <summary>
    /// A simple color struct containing 3 bytes.
    /// </summary>
    public struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        /// <summary>
        /// Initialises the color.
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        public Color( byte R, byte G, byte B ) : this( )
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        /// <summary>
        /// Initialises the color using unit floats.
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        public Color( float R, float G, float B )
            : this( ( byte ) ( R * 255 ), ( byte ) ( G * 255 ), ( byte ) ( B * 255 ) )
        {

        }
    }
}

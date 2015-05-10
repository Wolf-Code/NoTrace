using NoTrace.Core.Maths;

namespace NoTrace.Core
{
    abstract class RenderSettings
    {
        /// <summary>
        /// The resolution of the rendered image.
        /// </summary>
        public Vector2 Resolution { set; get; }
    }
}

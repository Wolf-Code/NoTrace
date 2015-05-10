using NoTrace.Core.Maths;

namespace NoTrace.Core
{
    public abstract class RenderSettings
    {
        /// <summary>
        /// The resolution of the rendered image.
        /// </summary>
        public Vector2 Resolution { set; get; }

        /// <summary>
        /// The field of view with which to render.
        /// </summary>
        public float FieldOfView { set; get; }
    }
}

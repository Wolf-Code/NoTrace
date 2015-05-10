
using NoTrace.Objects;

namespace NoTrace.Core
{
    /// <summary>
    /// An object which the renderer can render.
    /// </summary>
    public abstract class RendererObject
    {
        /// <summary>
        /// Returns data indicating the possible collision between a given ray and this object.
        /// </summary>
        /// <param name="R"></param>
        /// <returns></returns>
        public abstract CollisionData CollidesWith( Ray R );
    }
}

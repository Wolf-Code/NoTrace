using System;
using NoTrace.Core;

namespace NoTrace.Objects
{
    public class Sphere : RendererObject
    {
        public override CollisionData CollidesWith( Ray R )
        {
            throw new NotImplementedException( );
        }
    }
}

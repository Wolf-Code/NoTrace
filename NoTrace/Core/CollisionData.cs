using NoTrace.Core.Maths;

namespace NoTrace.Core
{
    public struct CollisionData
    {
        public bool Hit;
        public Vector3 Position;
        public Vector3 Normal;
        public float Distance;
        public RendererObject Object;
    }
}

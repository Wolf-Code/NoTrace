using System;
using NoTrace.Core;
using NoTrace.Core.Maths;

namespace NoTrace.Objects
{
    public class Sphere : RendererObject
    {
        public float Radius { set; get; }

        public float RadiusSquared => this.Radius * this.Radius;

        public Vector3 Position { set; get; }

        public override CollisionData CollidesWith( Ray R )
        {
            CollisionData Res = new CollisionData( );

            float A = R.Direction.Dot( R.Direction );
            float B = 2 * R.Direction.Dot( R.Start - this.Position );
            float C = ( R.Start - this.Position ).LengthSquared - this.RadiusSquared;

            float Discriminant = B * B - 4 * A * C;
            if ( Discriminant < 0 )
                return Res;

            float DiscriminantSqrt = ( float )Math.Sqrt( Discriminant );
            float Q;
            if ( B < 0 )
                Q = ( -B - DiscriminantSqrt ) / 2f;
            else
                Q = ( -B + DiscriminantSqrt ) / 2f;

            float T0 = Q / A;
            float T1 = C / Q;

            if ( T0 > T1 )
            {
                float TempT0 = T0;
                T0 = T1;
                T1 = TempT0;
            }

            // Sphere is behind the ray's start position.
            if ( T1 < 0 )
                return Res;

            Res.Distance = T0 < 0 ? T1 : T0;
            Res.Hit = true;
            Res.Position = R.Start + R.Direction * Res.Distance;
            Res.Normal = ( Res.Position - this.Position ).Normalized( );
            Res.Object = this;

            return Res;
        }
    }
}
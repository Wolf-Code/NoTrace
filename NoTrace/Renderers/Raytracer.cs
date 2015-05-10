using System;
using System.Collections.Generic;
using System.Linq;
using NoTrace.Core;
using NoTrace.Core.Maths;
using NoTrace.Objects;

namespace NoTrace.Renderers
{
    public class RaytracerSettings : RenderSettings
    {
        public RaytracerSettings( )
        {
            this.Resolution = new Vector2( 512, 512 );
        }
    }

    public class Raytracer : Renderer
    {
        protected override void PerformRender( ref RendererImage Image )
        {
            Ray R = new Ray { Start = new Vector3( 0, 0, 0 ), Direction = Vector3.UnitZ * -1 };
            CollisionData Hit =
                this.Scene.Objects.Select( O => O.CollidesWith( R ) )
                    .Where( O => O.Hit )
                    .OrderBy( O => O.Distance )
                    .FirstOrDefault( );

            if ( !Hit.Hit )
                Image.SetPixel( 0, 0, new Color( ) { G = 255 } );
            else
                Image.SetPixel( 0, 0, new Color( ) { R = 255 } );
        }
    }
}
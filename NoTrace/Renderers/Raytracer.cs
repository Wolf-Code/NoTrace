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
            for ( int X = 0; X < this.Settings.Resolution.X; X++ )
                for ( int Y = 0; Y < this.Settings.Resolution.Y; Y++ )
                {
                    Ray R = this.Camera.GetRayFromPixel( X, Y );
                    CollisionData Hit =
                        this.Scene.Objects.Select( O => O.CollidesWith( R ) )
                            .Where( O => O.Hit )
                            .OrderBy( O => O.Distance )
                            .FirstOrDefault( );

                    Image.SetPixel( X, Y, Hit.Hit ? new Color( 255, 0, 0 ) : new Color( 0, 255, 0 ) );
                }
        }
    }
}
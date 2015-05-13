
using System;
using System.Diagnostics;
using System.Drawing;
using NoTrace.Core;
using NoTrace.Core.Maths;
using NoTrace.Objects;
using NoTrace.Renderers;
using Color = NoTrace.Core.Color;

namespace NoTrace
{
    internal class Program
    {
        private static void Main( string [ ] args )
        {
            RenderScene Scene = new RenderScene( );
            Sphere S = new Sphere
            {
                Position = new Vector3( 0, 0, -40 ),
                Radius = 1
            };
            Scene.AddRendererObject( S );
            RenderSettings Settings = new RaytracerSettings( );

            Renderer R = new Raytracer( );
            R.SetData( Scene, Settings );
            RendererImage Render = R.Render( );
            Bitmap Bmp = Render.ConvertToBitmap( );
            Bmp.Save( "D:\\Temp\\tempimg.png" );
            Process.Start( "D:\\Temp\\tempimg.png" );
            Console.ReadLine( );
        }
    }
}
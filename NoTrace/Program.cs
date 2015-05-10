
using System;
using System.Diagnostics;
using System.Drawing;
using NoTrace.Core;
using NoTrace.Core.Maths;
using NoTrace.Renderers;
using Color = NoTrace.Core.Color;

namespace NoTrace
{
    internal class Program
    {
        private static void Main( string [ ] args )
        {
            RenderScene Scene = new RenderScene( );
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
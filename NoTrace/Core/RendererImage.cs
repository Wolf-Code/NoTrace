using System.Drawing;
using System.Drawing.Imaging;
using NoTrace.Core.Maths;

namespace NoTrace.Core
{
    public struct RendererImage
    {
        private readonly Color [ ] Data;
        private Vector2 Size;

        public RendererImage( Vector2 Resolution, Color [ ] Data )
        {
            this.Data = Data;
            this.Size = Resolution;
        }

        public RendererImage( Vector2 Resolution )
        {
            this.Data = new Color[ Resolution.IntX * Resolution.IntY ];
            this.Size = Resolution;
        }

        public Bitmap ConvertToBitmap( )
        {
            Bitmap Bmp = new Bitmap( this.Size.IntX, this.Size.IntY, PixelFormat.Format24bppRgb );

            // Lock the bits
            BitmapData ImgData = Bmp.LockBits( new Rectangle( 0, 0, Bmp.Width, Bmp.Height ), ImageLockMode.WriteOnly,
                Bmp.PixelFormat );

            // Get the width of each pixel's data in bytes.
            int PixelSize = Image.GetPixelFormatSize( Bmp.PixelFormat ) / 8;
            unsafe
            {
                for ( int Y = 0; Y < Bmp.Height; Y++ )
                {
                    // Get the byte array for this row.
                    byte* Row = ( byte* ) ImgData.Scan0 + Y * ImgData.Stride;
                    for ( int X = 0; X < Bmp.Width; X++ )
                    {
                        Color Col = this.Data[ Y * Bmp.Width + X ];

                        Row[ ( X * PixelSize ) + 2 ] = Col.R;
                        Row[ ( X * PixelSize ) + 1 ] = Col.G;
                        Row[ ( X * PixelSize ) ] = Col.B;
                    }
                }
            }

            Bmp.UnlockBits( ImgData );

            return Bmp;
        }

        /// <summary>
        /// Sets a pixel's color.
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="C"></param>
        public void SetPixel( int X, int Y, Color C )
        {
            this.Data[ Y * this.Size.IntX + X ] = C;
        }
    }
}

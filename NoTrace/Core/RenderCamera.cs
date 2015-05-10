
using NoTrace.Core.Maths;

namespace NoTrace.Core
{
    public class RenderCamera
    {
        public Vector3 Position
        {
            set
            {
                m_Position = value;
                this.SetUpMatrix(  );
            }
            get { return m_Position; }
        }

        private RenderSettings Settings;
        private Matrix4x4 Matrix;
        private Matrix4x4 Projection;
        private Vector3 m_Position;

        public RenderCamera( RenderSettings Settings )
        {
            this.Settings = Settings;

            this.Projection = Matrix4x4.CreateProjection( Settings.FieldOfView, Settings.FieldOfView, 1, 1000 );
        }

        public Vector3 GetDirectionFromPixel( float X, float Y )
        {
            
        }

        private void SetUpMatrix( )
        {
            Matrix = Matrix4x4.CreateTranslation( this.Position );
        }
    }
}
